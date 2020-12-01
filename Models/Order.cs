using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Order
    {
        public int orderNumber { get; set; }
        public int idClient { get; set; }
        public List<KeyValuePair<string,int>> foodItemList{ get; set; }
        public int precioTotal { get; set; }
    }
}