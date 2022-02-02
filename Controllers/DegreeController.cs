using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13316_egzamin_z_asp.net.Models
{
    public class DegreeController : Controller
    {
        public Dictionary<int, Degree> StudentGrades = new();
            public int index = 0;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPage()
        {
            return View("Add");
        }
        public IActionResult Add(Degree degree)
        {

            StudentGrades.Add(index, degree);
            index++;
            return View("Index", StudentGrades.Values.ToList());
        }
        
    
    }
}
