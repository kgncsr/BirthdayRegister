using BirthdayRegister.Models;
using BirthdayRegister.Views.Home;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayRegister.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Time = saat > 16 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Kağan";
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Person person)
        {
            if (ModelState.IsValid)
            {
                Repository.AddPerson(person);
                return View("Thanks", person);
            }
            return View(person);
          
        }


        public IActionResult List()
        {
            var result = Repository.Persons.Where(p => p.Confirm);
            return View(result);
        }


        public ActionResult Details()
        {

            var kurs = new Course() {Id=1,Name="C#"};

            var ogrenciler = new List<Student>()
            {
                new Student(){Name="ALİ"},
                new Student(){Name="AYSE"},
            };

            var viewmodel = new CoursePersonViewModel() { course = kurs, students = ogrenciler };

            return View(viewmodel);
        } 

    }
}
