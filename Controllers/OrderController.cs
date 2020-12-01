using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Orders()
        {
            KeyValuePair<string, int> foodIt1 = new KeyValuePair<string, int>("BBQ Ribs", 45);
            KeyValuePair<string, int> foodIt2 = new KeyValuePair<string, int>("Home Special", 100);
            KeyValuePair<string, int> foodIt3 = new KeyValuePair<string, int>("BBQ & Cheese Burger", 55);

            List<KeyValuePair<string, int>> foodList = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, int>> foodList2 = new List<KeyValuePair<string, int>>();


            foodList.Add(foodIt3);
            foodList.Add(foodIt2);

            foodList2.Add(foodIt3);
            foodList2.Add(foodIt1);

            List<Order> restaurantOrders = new List<Order>();
            restaurantOrders.Add(new Order {foodItemList=foodList,idClient=1,orderNumber=1,precioTotal=100 });
            restaurantOrders.Add(new Order { foodItemList = foodList2, idClient = 2, orderNumber = 2, precioTotal =155 });
            return View(restaurantOrders);
        }
    }
}