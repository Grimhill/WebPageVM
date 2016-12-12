using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebIntVM.Models;

namespace WebIntVM.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(CreateNewModel model)
        {
            var Json = model.GetJson();
            DAL.AzureQueue examp = new DAL.AzureQueue();
            examp.Queue(Json);
            return new EmptyResult();
        }
    }
}