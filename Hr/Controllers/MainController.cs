using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hr.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add_department()
        {
            return View();
        }
        public ActionResult Add_employee()
        {
            return View();
        }
        public ActionResult All_department()
        {
            return View();
        }
        public ActionResult All_employee()
        {
            return View();
        }
        public ActionResult View_edit_department()
        {
            return View();
        }
        public ActionResult View_edit_employee()
        {
            return View();
        }
    }
}