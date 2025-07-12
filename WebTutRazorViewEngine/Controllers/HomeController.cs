using Microsoft.AspNetCore.Mvc;
using WebTutRazorViewEngine.Models;

namespace WebTutRazorViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var person = new PersonViewModel()
            {
                FirstName = "Richmond",
                LastName = "Batoto",
                Gender = Gender.Male,
                Age = 21,
                FavoriteMovies = new List<string> { "Pirates of the Caribbean", "Miss Peregrine Home for Peculiar Children" }
            };

            return View(person);
        }

        public IActionResult Create()
        {
            return View(new PersonViewModel());
        }

        public IActionResult Createv2()
        {
            return View(new PersonViewModel()
            {
                FirstName = "Frace",
                IsVoter = true,
                Profession = "Programmer"
            });
        }

        public IActionResult Save(PersonViewModel submittedMode) 
        {
            //Do something here

            return View("Result", submittedMode);
        }

        public IActionResult TestFullName()
        {
            return PartialView("_FullName", new PersonViewModel
            {
                FirstName = "Test",
                LastName = "Only"
            });
        }
    }
}
