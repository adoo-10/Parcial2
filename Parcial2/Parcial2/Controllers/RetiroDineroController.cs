using System;
using Parcial2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2.Controllers
{
    public class RetiroDineroController : Controller
    {
        // GET: RetiroDinero
    
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult IndexR()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexR(RetiroDinero retiroDineroCls)
        { if (retiroDineroCls.monto % 5 == 0)
            {
                return Redirect("RetiroS");
            }

            return Redirect("RetiroN");
        }

        [HttpGet]
        public ActionResult RetiroS()
        {

            return View();
        }

        [HttpGet]
        public ActionResult RetiroN()
        {

            return View();
        }
    }

}