using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nile.Data.Sql;

namespace Nile.Web.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        // GET: Products
        public ActionResult Index()
        {
            var connString = ConfigurationManager.ConnectionStrings["NileDatabase"];
            var database = new SqlProductDatabase(connString.ConnectionString);

            var products = database.GetAll();

            return Json(products, JsonRequestBehavior.AllowGet);
        }

       
    }
}