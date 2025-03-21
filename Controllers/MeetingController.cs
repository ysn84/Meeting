using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models; // Ad alanını ekleyin
using Microsoft.Extensions.Logging;
using Meetingapp.Models;

namespace MeetingApp.Controllers // Ad alanını düzeltin
{
    public class MeetingController : Controller
    {


        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }





        [HttpGet]
        public IActionResult List()
        {


            return View(Repository.Users);
        }



        public IActionResult Details(int id)
        {

            return View(Repository.GetById(id));
        }
    }
}