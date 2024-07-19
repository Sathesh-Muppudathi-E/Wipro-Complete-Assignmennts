using Microsoft.AspNetCore.Mvc;
using EmployeeFormApp.Models;
using System.Collections.Generic;

namespace EmployeeFormApp.Controllers
{
    public class EmployeeController : Controller
    {
        // Static list to store employees in memory
        private static List<EmployeeForm> employees = new List<EmployeeForm>();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeForm model)
        {
            if (ModelState.IsValid)
            {
                // Add the new employee to the list
                employees.Add(model);

                // Redirect to the Success action or List action
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            // Pass the list of employees to the view
            return View(employees);
        }
    }
}
