using _3DSAutoTest.Entites.RetailTstEntites.responses;
using FluentAssertions;

namespace _3DSAutoTest.Validators
{
    public class ValidatorRetailTst
    {
        /// <summary>
        /// Проверить финальные параметры
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="param">С чем сравнивать</param>
        public static void CheckFinalStep(List<FinalParamResponse> response, List<FinalParamResponse> param)
        {
            response.Should().BeEquivalentTo(param);
        }
        /// <summary>
        /// Пытался посчитать что деньги пришли уперся в то что деньги приходят долго
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="amount"></param>
        public static void CheckBalance(DataScoreResponse before, DataScoreResponse after, string amount)
        {
            var beforeBalance = before.Balance;
            var afterBalance = after.Balance;
            var amountOp = Convert.ToInt32(amount);
            if ((beforeBalance + amountOp) == afterBalance)
            {
                Assert.Pass("Деньги успешно начислены");
            }
            else
            {
                Assert.Fail("Деньги не пришли");
            }
        }
        /// <summary>
        /// Пытался посчитать что деньги пришли уперся в то что деньги приходят долго
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="amount"></param>
        public static void CheckBalanceCard(DataCardResponse before, DataCardResponse after, string amount)
        {
            var beforeBalance = before.Balance;
            var afterBalance = after.Balance;
            var amountOp = Convert.ToInt32(amount);
            if ((beforeBalance + amountOp) == afterBalance)
            {
                Assert.Pass("Деньги успешно начислены");
            }
            else
            {
                Assert.Fail("Деньги не пришли");
            }
        }
    }
}
