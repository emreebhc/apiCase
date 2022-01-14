using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    public class ResponseModel
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
    }

    public class Body
    {
        public List<Intradaytradehistorylist> intraDayTradeHistoryList { get; set; }
        public List<Statistic> statistics { get; set; }
    }

    public class Intradaytradehistorylist
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string conract { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
    }

    public class Statistic
    {
        public DateTime date { get; set; }
        public float priceWeightedAverage { get; set; }
        public float priceMin { get; set; }
        public float priceMax { get; set; }
        public int quantityMin { get; set; }
        public int quantityMax { get; set; }
        public int quantitySum { get; set; }
    }

}
