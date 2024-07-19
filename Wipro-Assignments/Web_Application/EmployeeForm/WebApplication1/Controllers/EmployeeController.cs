using Microsoft.AspNetCore.Mvc;
using EmployeeFormApp.Models;
using System.Collections.Generic;
using System.Linq;

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

        [HttpGet]
        public IActionResult Details(int id)
        {
            // Find the employee by id
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Find the employee by id
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeForm model)
        {
            if (ModelState.IsValid)
            {
                // Find the employee by id
                var employee = employees.FirstOrDefault(e => e.Id == model.Id);
                if (employee == null)
                {
                    return NotFound();
                }

                // Update the employee details
                employee.Id = model.Id;
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.Age = model.Age;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Country = model.Country;
                employee.EmailId = model.EmailId;
                employee.Gender = model.Gender;

                // Redirect to the List action
                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Find the employee by id
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // Find the employee by id
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            // Remove the employee from the list
            employees.Remove(employee);

            // Redirect to the List action
            return RedirectToAction("List");
        }
    }
}
