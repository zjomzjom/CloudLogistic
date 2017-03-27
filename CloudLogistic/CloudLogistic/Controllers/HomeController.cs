using CloudLogistic.Data.Repositories;
using CloudLogistic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudLogistic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public IEnumerable<UserVM> GetUsers()
        {
            UsersRepository ur = new UsersRepository();
            var asd = ur.AllIdentityUsers();
            return asd.Select(x => new UserVM { UserId = x.Id, FirstName = x.Email, SecondName = "brak" }).ToList();
        }
    }
}
