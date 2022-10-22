using Microsoft.AspNetCore.Mvc;
using ProjectMvcNet.Models;
using System.Collections.Generic;

namespace ProjectMvcNet.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });

            return View(list);
        }
    }
}
