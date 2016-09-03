using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderRevised.Models;

namespace BartenderRevised.Controllers
{
    public class StoreController : Controller
    {
        BartenderRevisedEntities storeDB = new BartenderRevisedEntities();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            var drinktypes = storeDB.DrinkTypes.ToList();
            return View(drinktypes);
        }

        //
        // GET: /Store/Browse?type=Beer
        public ActionResult Browse(string type)
        {
            var typeModel = storeDB.DrinkTypes.Include("Brands").Single(g => g.Name == type);
            return View(typeModel);
        }
        
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var brand = storeDB.Brands.Find(id);
            return View(brand);
        }

    }
}
