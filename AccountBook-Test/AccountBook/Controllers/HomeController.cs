using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountBook.Models.ViewModels;

namespace AccountBook.Controllers
{
    public class HomeController : Controller
    {
        public enum AccountType
        { Income, Expenture };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChildActHistoryAction()
        {
            int index = 0;
            var accountLists = new List<RecordOfAccountModel>()
            {
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = (int)AccountType.Expenture,
                    Money = 50m,
                    Date = DateTime.Parse("2017-08-05"),
                    Description = "早餐-漢堡蛋＋紅茶"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = (int)AccountType.Expenture,
                    Money = 100m,
                    Date = DateTime.Parse("2017-08-05"),
                    Description = "午餐-雞腿便當"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = (int)AccountType.Expenture,
                    Money = 45m,
                    Date = DateTime.Parse("2017-08-05"),
                    Description = "文具-魔擦筆x1"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = (int)AccountType.Income,
                    Money = 1050m,
                    Date = DateTime.Parse("2017-08-05"),
                    Description = "7月管理委員會退費"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = (int)AccountType.Expenture,
                    Money = 30m,
                    Date = DateTime.Parse("2017-08-06"),
                    Description = "早餐-漢堡蛋"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = (int)AccountType.Expenture,
                    Money = 90m,
                    Date = DateTime.Parse("2017-08-06"),
                    Description = "午餐-排骨便當"
                },
            };

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