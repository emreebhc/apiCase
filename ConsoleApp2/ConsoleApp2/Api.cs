using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Api
    {
      public  void TestData()
        {

            var client = new RestClient("https://seffaflik.epias.com.tr/transparency/service/market/intra-day-trade-history?endDate=2022-01-13&startDate=2022-01-13");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            var data = JsonConvert.DeserializeObject<ResponseModel>(response.Content);
            foreach (var item in data.body.intraDayTradeHistoryList)
            {
                Console.WriteLine(item.conract);
            }
        }
    }
}
