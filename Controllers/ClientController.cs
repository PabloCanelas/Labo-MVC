using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult ListClients()
        {
            List<Client> clientBase = new List<Client>();

            clientBase.Add(new Client { id = 1, name = "Billie Gonzales", nit = 9923890 });
            clientBase.Add(new Client { id = 2, name = "Donald Trump", nit = 9665890 });
            clientBase.Add(new Client { id = 3, name = "Joaquin Sabina", nit = 2253890 });
            clientBase.Add(new Client { id = 4, name = "Charly Garcia", nit = 16453890 });

            return View(clientBase);
        }
    }
}