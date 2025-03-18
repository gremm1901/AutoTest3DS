using _3DSAutoTest.Clients;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSAutoTest.Helpers
{
    public class CheckStateOperation
    {
        public static bool CheckStateFOR(RetailTstClient client, long requestsId)
        {
            int a = 10;
            for (int i = 0; i < a; i++)
            {
                Thread.Sleep(8000);
                var state = client.GetState(requestsId);
                if (state.Content == "10") { return true; }
            }
            return false;
        }
        public static bool CheckStateDoWhile(RetailTstClient client, long requestsId)
        {
            int a = 10;
            var state = client.GetState(requestsId);
            do
            {
                Thread.Sleep(8000);
                a--;
                state = client.GetState(requestsId);
            }
            while (state.Content != "10" && a > 0);
            return (state.Content == "10") ? true : false;
        }
        public static void CheckState(RetailTstClient client, long requestsId)
        {
            var state = CheckStateDoWhile(client, requestsId);
            //if (state)
            //{
            //    Assert.Pass("Good");
            //}
            //else { Assert.Fail("fail"); }
            Assert.IsTrue(state, $"Операция не выполнена");
        }
    }
}