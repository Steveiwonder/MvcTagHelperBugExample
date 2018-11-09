using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers
{
    public class HomeController: Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View(new IndexViewModel()
            {
                People = new List<Person>()
                {
                    new Person()
                    {
                        Name = "Bob",
                        Id= 1
                    }
                }
            });
        }

        
    }

    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class IndexViewModel
    {
        public bool ACheckbox { get; set; }
        public List<Person> People { get; set; }
        public int SelectedPerson { get; set; }
    }
}
