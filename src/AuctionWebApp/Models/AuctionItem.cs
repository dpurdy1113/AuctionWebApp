using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebApp.Models
{
    public class AuctionItem
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int minimumBid { get; set; }
        public int numberOfBids { get; set; }

    }
}
