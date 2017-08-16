using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountBook.Models;
using AccountBook.Models.ViewModels;
using AccountBook = AccountBook.Models.AccountBook;

namespace AccountBook.Controllers
{
    public class HomeController : Controller
    {
        private SkillTreeHomeworkEntities context = new SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChildActHistoryAction()
        {
            var accountLists = new List<RecordOfAccountModel>();
            int i = 0;
            foreach (var item in context.AccountBook)
            {
                var recordOfAccountModel = new RecordOfAccountModel()
                {
                    Id = ++i,
                    Type = item.Categoryyy,
                    Date = item.Dateee,
                    Money = item.Amounttt,
                    Description = item.Remarkkk
                };
                accountLists.Add(recordOfAccountModel);
            }

            return View(accountLists);
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