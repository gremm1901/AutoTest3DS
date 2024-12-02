using _3DSAutoTest.Entites._3DSEntites.Requests;
using _3DSAutoTest.Entites.RetailTstEntites.responses;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSAutoTest.Clients
{
    /// <summary>
    /// Класс по работе с 3DS
    /// </summary>
    public class _3DSClient
    {
        RestClient _client;
        public _3DSClient(string url)
        {
            _client = new RestClient(url);
        }
        /// <summary>
        /// Первый шаг 3DS для операции 2429
        /// </summary>
        /// <param name="gid">параметр URL</param>
        /// <param name="body">Данные для запуска</param>
        /// <returns></returns>
        public RestResponse Start3DSC2A(string gid, Start3DSC2ARequest body)
        {
            var request = new RestRequest($"/way4acs/pa?id={gid}.OC", Method.Post);

            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            request.AddParameter("PaReq", body.PaReq, ParameterType.GetOrPost);
            request.AddParameter("MD", body.MD, ParameterType.GetOrPost);
            request.AddParameter("TermUrl", body.TermUrl, ParameterType.GetOrPost);

            return _client.Execute(request);
        }
        /// <summary>
        /// Пордтверждение 3DS, ввод пароля
        /// </summary>
        /// <param name="gid"></param>
        /// <param name="Password">Пароль для 3DS</param>
        /// <returns></returns>
        public RestResponse Confirm3DSC2A(string gid, string Password)
        {
            var request = new RestRequest("/way4acs/uidispatcher", Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            request.AddParameter("PASSWORD", Password, ParameterType.GetOrPost);
            request.AddParameter("formaction", "pa.submit", ParameterType.GetOrPost);
            request.AddParameter("PSW_RENEW", "Y", ParameterType.GetOrPost);
            request.AddParameter("TRIES", "Y", ParameterType.GetOrPost);
            request.AddParameter("gid", gid, ParameterType.GetOrPost);
            return _client.Execute(request);
        }
        /// <summary>
        /// Финальный шаг 3DS
        /// </summary>
        /// <param name="PaRes"></param>
        /// <param name="MD"></param>
        /// <returns></returns>
        public RestResponse Final3DSC2A(string PaRes, string MD)
        {
            var request = new RestRequest($"/cgi-bin/cgi_link", Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("PaRes", PaRes, ParameterType.GetOrPost);
            request.AddParameter("MD", MD, ParameterType.GetOrPost);
            return _client.Execute(request);
        }
    }
}
