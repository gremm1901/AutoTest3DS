using _3DSAutoTest.Clients;
using _3DSAutoTest.Entites._3DSEntites.Requests;
using _3DSAutoTest.Entites.RetailTstEntites.requests;
using _3DSAutoTest.Entites.RetailTstEntites.responses;
using _3DSAutoTest.Helpers;

namespace _3DSAutoTest.Tests
{
    public class Tests
    {

        [Test]
        public void CardToScoreC2A()
        {
            //arrange
            var param = new List<FinalParamResponse> {
                new FinalParamResponse
                {
                    Name= "Сумма перевода",
                    Value= "1 000.00"
                },
                new FinalParamResponse
                {
                    Name= "Комиссия",
                    Value= "0.00"
                },
                new FinalParamResponse
                {
                    Name= "Терминал",
                    Value= "27882143"
                },
                new FinalParamResponse
                {
                    Name= "Карта отправителя",
                    Value= "4762 08.. .... 3998"
                },
                new FinalParamResponse
                {
                    Name= "Счет зачисления",
                    Value= "40817810940001567736"
                }
            };

            var startOpReq = new OperationCodeRequest
            {
                OperationCode = 2429
            };
            var salt = new SaltRequests
            {
                ClientIdentifier = "22797853",
                LoginType = "login"
            };

            var clientRetail = new RetailTstClient("https://retail-tst.payment.ru");
            var client3ds = new _3DSClient("https://test.3ds.payment.ru");

            //act
            var auth = clientRetail.AuthClient(salt);
            //Assert
            Helpers.AssertionHelper.ChecksStatus(auth);

            //act
            var beforeBalance = clientRetail.GetScoreInfo("1536255826");
            var startOpResp = clientRetail.StartOperation(startOpReq);
            //Assert
            Helpers.AssertionHelper.ChecksStatus(startOpResp);

            //arrange
            var nextOpReq = new NextStepRequest
            {
                Params = new List<ParamRequest> {
                new ParamRequest {
                Identifier = "Amount",
                Value = param[0].Value},
                new ParamRequest {
                Identifier = "CurrencyID",
                Value = "RUR"},
                new ParamRequest {
                Identifier = "Commission",
                Value = 0},
                new ParamRequest {
                Identifier = "TransferKind",
                Value = 1},
                new ParamRequest {
                Identifier = "UseComissonFreeTerminal",
                Value = ""},
                new ParamRequest {
                Identifier = "SenderCardId",
                Value = "229;63579"},
                new ParamRequest {
                Identifier = "NeedSaveSenderCard",
                Value = "true"},
                new ParamRequest {
                Identifier = "SenderStoredCards",
                Value = startOpResp.Data.Params[19].Value.Value},
                new ParamRequest {
                Identifier = "NeedSaveSenderCard",
                Value = "true"},
                new ParamRequest {
                Identifier = "SenderCardNotChanged",
                Value = "true"},
                new ParamRequest {
                Identifier = "NeedSaveReceiverCard",
                Value = "true"},
                new ParamRequest {
                Identifier = "ReceiverCardNotChanged",
                Value = "true"},
                new ParamRequest {
                Identifier = "ReceiverAccountNumber",
                Value = param[4].Value},
                new ParamRequest {
                Identifier = "AgreementConfirmed",
                Value = "true"},
            }
            };

            //act
            var nextstepResp = clientRetail.NextStepOperationC2A(nextOpReq, startOpResp.Data.RequestId);

            //arrange
            string gid = GetValueHTML.GetGid(nextstepResp.Data.Params[1].Value.Value.ToString());
            var star3dsReq = new Start3DSC2ARequest
            {
                PaReq = GetValueHTML.GetValue("PaReq", nextstepResp.Data.Params[1].Value.Value.ToString()),
                MD = GetValueHTML.GetValue("MD", nextstepResp.Data.Params[1].Value.Value.ToString()),
                TermUrl = "https://test.3ds.payment.ru/cgi-bin/cgi_link"
            };

            //act
            var star3ds = client3ds.Start3DSC2A(gid, star3dsReq);
            var next3ds = client3ds.Confirm3DSC2A(gid, "111111");

            //arrange
            string PaRes = GetValueHTML.GetValue("PaRes", next3ds.Content);

            //act
            var final3ds = client3ds.Final3DSC2A(PaRes, star3dsReq.MD);
            //Assert
            Helpers.AssertionHelper.ChecksStatus(final3ds);

            //arrange
            var finalResp = new NextStepRequest
            {
                Params = new List<ParamRequest> {
                new ParamRequest {
                Identifier = "AmountIn3DS",
                Value = GetValueHTML.GetValue("AMOUNT", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "CurrencyIn3DS",
                Value = GetValueHTML.GetValue("CURRENCY", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "OrderIn3DS",
                Value = GetValueHTML.GetValue("ORDER", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "MerchantNameIn3DS",
                Value = GetValueHTML.GetValue("MERCH_NAME", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "MerchantIn3DS",
                Value = GetValueHTML.GetValue("MERCHANT", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "TerminalIn3DS",
                Value = GetValueHTML.GetValue("TERMINAL", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "TrTypeIn3DS",
                Value = GetValueHTML.GetValue("TRTYPE", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "TransactionTimeIn3DS",
                Value = GetValueHTML.GetValue("TIMESTAMP", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "NonceIn3DS",
                Value = GetValueHTML.GetValue("NONCE", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "ResultIn3DS",
                Value = GetValueHTML.GetValue("RESULT", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "RcCodeIn3DS",
                Value = GetValueHTML.GetValue("RC", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "RcTextIn3DS",
                Value = GetValueHTML.GetValue("RCTEXT", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "AuthCodeIn3DS",
                Value = GetValueHTML.GetValue("AUTHCODE", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "RrnIn3DS",
                Value = GetValueHTML.GetValue("RRN", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "PSignIn3DS",
                Value = GetValueHTML.GetValue("P_SIGN", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "IntRefIn3DS",
                Value = GetValueHTML.GetValue("INT_REF", final3ds.Content.ToString())},
                new ParamRequest {
                Identifier = "BackRefIn3DS",
                },
                new ParamRequest {
                Identifier = "NotifyUrl",
                },
                new ParamRequest {
                Identifier = "Html",
                },
                }
            };

            //act
            var stepTwo = clientRetail.NextTwoStepOperationC2A(finalResp, startOpResp.Data.RequestId);
            var final = clientRetail.FinelStepOperationC2A(startOpResp.Data.RequestId);
            var afterBalance = clientRetail.GetScoreInfo("1536255826");
            //Assert
            Helpers.AssertionHelper.ChecksStatus(final);
            Validators.ValidatorRetailTst.CheckFinalStep(final.Data.FinalParams, param);
            //Не работает слишком долго приходят деньги
            //Validators.ValidatorRetailTst.CheckBalance(beforeBalance.Data, afterBalance.Data, "1000");
        }
    }
}