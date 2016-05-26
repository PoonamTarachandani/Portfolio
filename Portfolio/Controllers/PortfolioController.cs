using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioEntities db = new PortfolioEntities();
        // GET: Portfolio
        public ActionResult Index()
        {
            return View(db.Projects);
        }
    }
}