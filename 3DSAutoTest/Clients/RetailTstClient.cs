using _3DSAutoTest.Entites.RetailTstEntites.requests;
using _3DSAutoTest.Entites.RetailTstEntites.responses;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace _3DSAutoTest.Clients
{
    public class RetailTstClient
    {
        RestClient _client;
        public RetailTstClient(string url)
        {
            var options = new RestClientOptions(url);
            options.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            _client = new RestClient(options);

        }
        /// <summary>
        /// Старт Операции
        /// </summary>
        /// <param name="body">Код операции</param>
        /// <returns></returns>
        public RestResponse<StartOperatonResponse> StartOperation(OperationCodeRequest body)
        {
            var request = new RestRequest("/api/operations/requests", Method.Post);
            request.AddBody(body);

            return _client.Execute<StartOperatonResponse>(request);
        }
        /// <summary>
        /// Ввод откуда,куда и сколько
        /// </summary>
        /// <param name="body">Данные для перевода</param>
        /// <param name="requestId">ID операции</param>
        /// <returns></returns>
        public RestResponse<NextStepResponse> NextStepOperationC2A(NextStepRequest body, long requestId)
        {
            var request = new RestRequest($"/api/operations/requests/{requestId}/nextStep", Method.Post);
            request.AddBody(body);

            return _client.Execute<NextStepResponse>(request);
        }
        /// <summary>
        /// Передача данных с экрана 3DS
        /// </summary>
        /// <param name="body">Данные что нам передал 3DS</param>
        /// <param name="requestId">ID операции</param>
        /// <returns></returns>
        public RestResponse<NextStepResponse> NextTwoStepOperationC2A(NextStepRequest body, long requestId)
        {
            var request = new RestRequest($"/api/operations/requests/{requestId}/nextStep", Method.Post);
            request.AddBody(body);

            return _client.Execute<NextStepResponse>(request);
        }
        /// <summary>
        /// Финальный экран
        /// </summary>
        /// <param name="requestId">ID операции</param>
        /// <returns></returns>
        public RestResponse<FinalOParationResponse> FinelStepOperationC2A(long requestId)
        {
            var request = new RestRequest($"/api/operations/requests/{requestId}/confirmandfinalize", Method.Post);

            return _client.Execute<FinalOParationResponse>(request);
        }

        //Авторизация
        /// <summary>
        /// Получение соли для пароля
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        private RestResponse<SaltResponse> Salt(SaltRequests body)
        {
            var request = new RestRequest("/s/auth/authentication/salt", Method.Post);
            request.AddBody(body);

            return _client.Execute<SaltResponse>(request);
        }
        /// <summary>
        /// Получение первичного токена
        /// </summary>
        /// <param name="body">Данные клиента для входа</param>
        /// <returns></returns>
        private RestResponse<FirstTokenResponse> FirstToken(FirstTokenRequest body)
        {
            var request = new RestRequest("/s/auth/connect/token", Method.Post);

            request.AddParameter("username", body.Username, ParameterType.GetOrPost);
            request.AddParameter("password", body.Password, ParameterType.GetOrPost);
            request.AddParameter("requestId", body.RequestId, ParameterType.GetOrPost);
            request.AddParameter("client_id", body.ClientId, ParameterType.GetOrPost);
            request.AddParameter("returnLoginResult", body.ReturnLoginResult, ParameterType.GetOrPost);
            request.AddParameter("scope", body.Scope, ParameterType.GetOrPost);
            request.AddParameter("grant_type", body.GrantType, ParameterType.GetOrPost);
            request.AddParameter("loginType", body.LoginType, ParameterType.GetOrPost);

            return _client.Execute<FirstTokenResponse>(request);
        }
        /// <summary>
        /// Переход на экран с смс кодом
        /// </summary>
        /// <param name="token">Промежуточный токен</param>
        /// <returns></returns>
        private RestResponse<SecondStepAuthRespomse> SecondStepAuthRequest(string token)
        {
            var request = new RestRequest($"/s/auth/authentication/secondStepAuthRequest", Method.Post);

            request.AddHeader("Authorization", "Bearer " + token);
            request.AddBody(new object { });

            return _client.Execute<SecondStepAuthRespomse>(request);
        }
        /// <summary>
        /// Получение финального токена
        /// </summary>
        /// <param name="body">Данные для получения финального токена</param>
        /// <param name="token">Промежуточный токен</param>
        /// <returns></returns>
        private RestResponse<FinalTokenResponse> FinalToken(FinalTokenRequest body, string token)
        {
            var request = new RestRequest("/s/auth/connect/token", Method.Post);

            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Bearer " + token);

            request.AddParameter("usedChannel", body.UsedChannel, ParameterType.GetOrPost);
            request.AddParameter("code", body.Code, ParameterType.GetOrPost);
            request.AddParameter("returnLoginResult", body.ReturnLoginResult, ParameterType.GetOrPost);
            request.AddParameter("client_id", body.ClientId, ParameterType.GetOrPost);
            request.AddParameter("scope", body.Scope, ParameterType.GetOrPost);
            request.AddParameter("grant_type", body.GrantType, ParameterType.GetOrPost);
            request.AddParameter("loginType", body.LoginType, ParameterType.GetOrPost);

            return _client.Execute<FinalTokenResponse>(request);
        }
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="nk">нк для входа</param>
        /// <param name="pass">роль от учетки по штату 1111111</param>
        public RestResponse AuthClient(string nk, string pass = "1111111")
        {
            var saltBody = new SaltRequests
            {
                ClientIdentifier = nk,
                LoginType = "login"
            };
            var salt = Salt(saltBody);
            var pwd = Helpers.PasswordSalt.SaltPassword(pass, salt.Data.PasswordSalt, salt.Data.SessionSalt);
            var tokenReq = new FirstTokenRequest
            {
                Username = saltBody.ClientIdentifier,
                Password = pwd,
                RequestId = salt.Data.RequestId,
                ClientId = "website",
                ReturnLoginResult = "1",
                Scope = "offline_access retail_client",
                GrantType = "password",
                LoginType = "login"
            };

            var firstToken = FirstToken(tokenReq);
            var secondStepAuthRequestlt = SecondStepAuthRequest(firstToken.Data.AccessToken);

            var finTokenReq = new FinalTokenRequest
            {
                UsedChannel = "1",
                Code = "111111",
                ReturnLoginResult = "1",
                ClientId = "website",
                Scope = "offline_access retail_client",
                GrantType = "second_step",
                LoginType = "login"
            };

            var request = FinalToken(finTokenReq, firstToken.Data.AccessToken);

            _client.AddDefaultHeader("Authorization", "Bearer " + request.Data.AccessToken);
            return request;
        }
        /// <summary>
        /// Запросить все данные по карте
        /// </summary>
        /// <param name="idCard">Ид карты</param>
        /// <returns></returns>
        public RestResponse<DataCardResponse> GetCardInfo(string idCard)
        {
            var request = new RestRequest($"/c/cards-clientapi/cards/accounts/{idCard}", Method.Post);
            return _client.Execute<DataCardResponse>(request);
        }
        /// <summary>
        /// Запросить все данные по счету
        /// </summary>
        /// <param name="idScore">Ид счета</param>
        /// <returns></returns>
        public RestResponse<DataScoreResponse> GetScoreInfo(string idScore)
        {
            var request = new RestRequest($"/api/accounts/{idScore}", Method.Get);
            return _client.Execute<DataScoreResponse>(request);
        }
        /// <summary>
        /// Получить статус по операции
        /// </summary>
        /// <param name="requestId">Номер поручения</param>
        /// <returns></returns>
        public RestResponse GetState(long requestId)
        {
            return _client.Execute(new RestRequest($"/api/operations/requests/{requestId}/state", Method.Get));
        }
    }
}