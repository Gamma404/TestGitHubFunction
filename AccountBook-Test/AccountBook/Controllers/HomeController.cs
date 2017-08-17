using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using AccountBook.Models;
using AccountBook.Models.ViewModels;
using AccountBook = AccountBook.Models.AccountBook;

namespace AccountBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountService _acountSvc;

        public HomeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _acountSvc = new AccountService(unitOfWork);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChildActHistoryAction()
        {
            var source = _acountSvc.Lookup();
            return View(source);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}