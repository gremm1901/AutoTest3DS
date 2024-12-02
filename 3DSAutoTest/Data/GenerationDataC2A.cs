using _3DSAutoTest.Entites._3DSEntites.Requests;
using _3DSAutoTest.Entites.RetailTstEntites.requests;
using _3DSAutoTest.Entites.RetailTstEntites.responses;
using _3DSAutoTest.Enums;
using _3DSAutoTest.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSAutoTest.Data
{
    public class GenerationDataC2A
    {
        /// <summary>
        /// Создает Request для первого шага операции
        /// </summary>
        /// <param name="param"></param>
        /// <param name="startOpResp">Responses первого шага</param>
        /// <returns></returns>
        public static NextStepRequest GenerationNextStep(List<FinalParamResponse> param, StartOperatonResponse startOpResp)
        {
            return new NextStepRequest
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
                new ParamRequest
                {
                    Identifier="SenderCardNumber",
                    Value= "4762085995973998"
                },
                new ParamRequest
                {
                    Identifier="SenderCardName",
                    Value= "Промсвязьбанк"
                },
                new ParamRequest
                {
                    Identifier="ExpMonth",
                    Value= "12"
                },
                new ParamRequest
                {
                    Identifier="ExpYear",
                    Value= "24"
                },
                new ParamRequest
                {
                    Identifier="Cvc2",
                    Value= "111"
                },
                new ParamRequest {
                Identifier = "SenderCardId"},
                new ParamRequest {
                Identifier = "NeedSaveSenderCard",
                Value = "true"},
                new ParamRequest {
                Identifier = "SenderStoredCards",
                Value = startOpResp.Params[19].Value.Value},
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
                Value = "40817810540001167413"},
                new ParamRequest {
                Identifier = "AgreementConfirmed",
                Value = "true"},
            }
            };
        }
        /// <summary>
        /// Генерация финального респонса для проверок
        /// </summary>
        /// <param name="summ">сумма платежа</param>
        /// <param name="comision">комиссия</param>
        /// <param name="terminal">терминал что используется в переводе</param>
        /// <param name="senderCard">карта отправителя</param>
        /// <param name="reciverAccount">Счет получателя</param>
        /// <returns></returns>
        public static List<FinalParamResponse> GenerationFinalResponsesC2A(
            string summ = "1 000.00", string comision = "0.00", string terminal = "27882143",
            string senderCard = "4762 08.. .... 3998", string reciverAccount = "40817810540001167413")
        {
            return new List<FinalParamResponse> {
                new FinalParamResponse
                {
                    Name= "Сумма перевода",
                    Value= summ
                },
                new FinalParamResponse
                {
                    Name= "Комиссия",
                    Value= comision
                },
                new FinalParamResponse
                {
                    Name= "Терминал",
                    Value= terminal
                },
                new FinalParamResponse
                {
                    Name= "Карта отправителя",
                    Value= senderCard
                },
                new FinalParamResponse
                {
                    Name= "Счет зачисления",
                    Value= reciverAccount
                }
            };
        }
        /// <summary>
        /// Генерация реквест боди для старта экрана 3ds
        /// </summary>
        /// <param name="nextstepResp">ОТвет от первого шага</param>
        /// <returns></returns>
        public static Start3DSC2ARequest GenerationStart3dsReqC2A(NextStepResponse nextstepResp)
        {
            return new Start3DSC2ARequest
            {
                PaReq = GetValueHTML.GetValue("PaReq", nextstepResp.Params[1].Value.Value.ToString()),
                MD = GetValueHTML.GetValue("MD", nextstepResp.Params[1].Value.Value.ToString()),
                TermUrl = "https://test.3ds.payment.ru/cgi-bin/cgi_link"
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static OperationCodeRequest GenarationCodeOperations(CodeOperationsEnum code)
        {

            return new OperationCodeRequest
            {
                OperationCode = Convert.ToInt32(EnumHelper.GetDescription(code))
            };
        }
        public static NextStepRequest GenarationNextStep3DS(string final3ds)
        {
            return new NextStepRequest
            {
                Params = new List<ParamRequest> {
                new ParamRequest {
                Identifier = "AmountIn3DS",
                Value = GetValueHTML.GetValue("AMOUNT", final3ds)},
                new ParamRequest {
                Identifier = "CurrencyIn3DS",
                Value = GetValueHTML.GetValue("CURRENCY", final3ds)},
                new ParamRequest {
                Identifier = "OrderIn3DS",
                Value = GetValueHTML.GetValue("ORDER", final3ds)},
                new ParamRequest {
                Identifier = "MerchantNameIn3DS",
                Value = GetValueHTML.GetValue("MERCH_NAME", final3ds)},
                new ParamRequest {
                Identifier = "MerchantIn3DS",
                Value = GetValueHTML.GetValue("MERCHANT", final3ds)},
                new ParamRequest {
                Identifier = "TerminalIn3DS",
                Value = GetValueHTML.GetValue("TERMINAL", final3ds)},
                new ParamRequest {
                Identifier = "TrTypeIn3DS",
                Value = GetValueHTML.GetValue("TRTYPE", final3ds)},
                new ParamRequest {
                Identifier = "TransactionTimeIn3DS",
                Value = GetValueHTML.GetValue("TIMESTAMP", final3ds)},
                new ParamRequest {
                Identifier = "NonceIn3DS",
                Value = GetValueHTML.GetValue("NONCE", final3ds)},
                new ParamRequest {
                Identifier = "ResultIn3DS",
                Value = GetValueHTML.GetValue("RESULT", final3ds)},
                new ParamRequest {
                Identifier = "RcCodeIn3DS",
                Value = GetValueHTML.GetValue("RC", final3ds)},
                new ParamRequest {
                Identifier = "RcTextIn3DS",
                Value = GetValueHTML.GetValue("RCTEXT", final3ds)},
                new ParamRequest {
                Identifier = "AuthCodeIn3DS",
                Value = GetValueHTML.GetValue("AUTHCODE", final3ds)},
                new ParamRequest {
                Identifier = "RrnIn3DS",
                Value = GetValueHTML.GetValue("RRN", final3ds)},
                new ParamRequest {
                Identifier = "PSignIn3DS",
                Value = GetValueHTML.GetValue("P_SIGN", final3ds)},
                new ParamRequest {
                Identifier = "IntRefIn3DS",
                Value = GetValueHTML.GetValue("INT_REF", final3ds)},
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

        }
        public static NextStepRequest GenerationNextStepC2C(List<FinalParamResponse> param, StartOperatonResponse startOpResp)
        {
            return new NextStepRequest
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
                Identifier = "ClientCards",
                Value = startOpResp.Params[4].Value.Value},
                new ParamRequest {
                Identifier = "TransferKind",
                Value = 0},
                new ParamRequest {
                Identifier = "UseComissonFreeTerminal",
                Value = ""},
                new ParamRequest
                {
                    Identifier="SenderCardNumber",
                    Value= "4762085995973998"
                },
                new ParamRequest
                {
                    Identifier="SenderCardName",
                    Value= "Промсвязьбанк123"
                },
                new ParamRequest
                {
                    Identifier="ExpMonth",
                    Value= "12"
                },
                new ParamRequest
                {
                    Identifier="ExpYear",
                    Value= "24"
                },
                new ParamRequest
                {
                    Identifier="Cvc2",
                    Value= "111"
                },
                new ParamRequest {
                Identifier = "SenderCardId"},
                new ParamRequest {
                Identifier = "NeedSaveSenderCard",
                Value = "true"},
                new ParamRequest {
                Identifier = "NeedSaveSenderCard",
                Value = "true"},
                new ParamRequest
                {
                    Identifier="ReceiverCardId",
                    Value= "207;1968055960"
                },
                new ParamRequest
                {
                    Identifier="AccountType",
                    Value= 209
                },
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
                Identifier = "AgreementConfirmed",
                Value = "true"},
            }
            };
        }
    }
}
