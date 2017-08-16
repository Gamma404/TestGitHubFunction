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
                    Type = 0,
                    Money = 50m,
                    Date = new DateTime(2017,8,5),
                    Description = "早餐-漢堡蛋＋紅茶"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = 0,
                    Money = 100m,
                    Date = new DateTime(2017,8,5),
                    Description = "午餐-雞腿便當"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = 0,
                    Money = 45m,
                    Date = new DateTime(2017,8,5),
                    Description = "文具-魔擦筆x1"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = 0,
                    Money = 1050m,
                    Date = new DateTime(2017,8,5),
                    Description = "7月管理委員會退費"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = 0,
                    Money = 30m,
                    Date = new DateTime(2017,8,5),
                    Description = "早餐-漢堡蛋"
                },
                new RecordOfAccountModel()
                {
                    Id = ++index,
                    Type = 0,
                    Money = 90m,
                    Date = new DateTime(2017,8,5),
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