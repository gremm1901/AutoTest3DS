using _3DSAutoTest.Clients;
using _3DSAutoTest.Data;
using _3DSAutoTest.Entites._3DSEntites.Requests;
using _3DSAutoTest.Entites.RetailTstEntites.requests;
using _3DSAutoTest.Entites.RetailTstEntites.responses;
using _3DSAutoTest.Enums;
using _3DSAutoTest.Helpers;

namespace _3DSAutoTest.Tests
{
    public class Tests
    {

        [Test]
        public void CardToScoreC2A()
        {
            //arrange
            var param = GenerationDataC2A.GenerationFinalResponsesC2A();
            var startOpReq = GenerationDataC2A.GenarationCodeOperations(CodeOperationsEnum.Crad2Account);
            var clientRetail = new RetailTstClient("https://retail-tst.payment.ru");
            var client3ds = new _3DSClient("https://test.3ds.payment.ru");
            //act
            var auth = clientRetail.AuthClient("337054");
            var beforeBalance = clientRetail.GetScoreInfo("1535632325");
            var startOpResp = clientRetail.StartOperation(startOpReq);
            //arrange
            var nextOpReq = GenerationDataC2A.GenerationNextStep(param, startOpResp.Data);
            //act
            var nextstepResp = clientRetail.NextStepOperationC2A(nextOpReq, startOpResp.Data.RequestId);
            //arrange
            string gid = GetValueHTML.GetGid(nextstepResp.Data.Params[1].Value.Value.ToString());
            var star3dsReq = GenerationDataC2A.GenerationStart3dsReqC2A(nextstepResp.Data);
            //act
            client3ds.Start3DSC2A(gid, star3dsReq);
            var next3ds = client3ds.Confirm3DSC2A(gid, "111111");
            var final3ds = client3ds.Final3DSC2A(next3ds.Content, star3dsReq.MD);
            //arrange
            var finalResp = GenerationDataC2A.GenarationNextStep3DS(final3ds.Content.ToString());
            //act
            clientRetail.NextTwoStepOperationC2A(finalResp, startOpResp.Data.RequestId);
            var final = clientRetail.FinelStepOperationC2A(startOpResp.Data.RequestId);
            CheckStateOperation.CheckState(clientRetail, startOpResp.Data.RequestId);
            var afterBalance = clientRetail.GetScoreInfo("1535632325");
            //Assert
            Helpers.AssertionHelper.ChecksStatus(final);
            Validators.ValidatorRetailTst.CheckFinalStep(final.Data.FinalParams, param);
            Validators.ValidatorRetailTst.CheckBalance(beforeBalance.Data, afterBalance.Data, "1000");
        }
        [Test]
        public void Card2Card()
        {
            //arrange
            var param = GenerationDataC2A.GenerationFinalResponsesC2A();
            var startOpReq = GenerationDataC2A.GenarationCodeOperations(CodeOperationsEnum.Crad2Card);
            var clientRetail = new RetailTstClient("https://retail-tst.payment.ru");
            var client3ds = new _3DSClient("https://test.3ds.payment.ru");
            //act
            clientRetail.AuthClient("337054");
            var beforeBalance = clientRetail.GetCardInfo("1968055950");
            var startOpResp = clientRetail.StartOperation(startOpReq);
            var nextstepResp = clientRetail.NextStepOperationC2A(GenerationDataC2A.GenerationNextStepC2C(param, startOpResp.Data), startOpResp.Data.RequestId);
            var final3ds = client3ds.C2C3DS(nextstepResp.Data.Params[1].Value.Value.ToString());
            clientRetail.NextTwoStepOperationC2A(GenerationDataC2A.GenarationNextStep3DS(final3ds.Content.ToString()), startOpResp.Data.RequestId);
            var final = clientRetail.FinelStepOperationC2A(startOpResp.Data.RequestId);
            CheckStateOperation.CheckState(clientRetail, startOpResp.Data.RequestId);
            var afterBalance = clientRetail.GetCardInfo("1968055950");
            //Assert
            Helpers.AssertionHelper.ChecksStatus(final);
            Validators.ValidatorRetailTst.CheckFinalStep(final.Data.FinalParams, param);
            Validators.ValidatorRetailTst.CheckBalanceCard(beforeBalance.Data, afterBalance.Data, "1000");
        }
    }
}