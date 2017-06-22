using onlineshop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace onlineshop.Controllers
{
    public class SearchController : Controller
    {

        private ApplicationDbContext _context;
        private List<Product> listProducts;

        public SearchController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Search
        public ActionResult Index()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchtext)
        {
            listProducts = _context.products.Where(p=>p.NAME.Contains(searchtext)).ToList();

            /*foreach (Product t in listProducts) {
                string path = "~/App_Data/products/"+t.LOCATION;
                listProducts.Find(p => p.PRODUCTID == t.PRODUCTID).LOCATION = path;
            }*/
            

            return View("Search",listProducts);
        }

        [HttpGet]
        public ActionResult detail(int productid)
        {
            Product pro =_context.products.Where(p => p.PRODUCTID.Equals(productid)).First<Product>();
            //string path = "~/App_Data/products/" + pro.LOCATION;
            //pro.LOCATION = path;
            return View("DetailView", pro);
        }



    }
}