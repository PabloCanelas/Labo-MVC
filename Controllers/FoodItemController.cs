using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class FoodItemController : Controller
    {
        // GET: FoodItem
        public ActionResult Menu()
        {
            List<FoodItem> foodList = new List<FoodItem>();
            foodList.Add(new FoodItem { name = "BBQ Ribs", price = 45, type = "Meat" });
            foodList.Add(new FoodItem { name = "BBQ & Cheese Burger", price = 55, type = "Burger" });
            foodList.Add(new FoodItem { name = "Hawaian Pizza", price = 79, type = "Pizza" });
            foodList.Add(new FoodItem { name = "Caesar Salad", price = 35, type = "Salad" });
            foodList.Add(new FoodItem { name = "Home Special", price = 100, type = "Week's Special" });

            return View(foodList);
        }
    }
}