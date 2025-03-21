using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
using Meetingapp.Models;


namespace Meetingapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int saat = DateTime.Now.Hour;
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

            ViewBag.selamlama = saat > 12 ? "İyi Günler" : "Günaydın";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Abc kongre merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}