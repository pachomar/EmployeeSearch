using MasGlobal.Business;
using MasGlobal.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace MasGlobal.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee1
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get(int employeeId)
        {
            IEnumerable<Employee> listOfEmployees = GetEmployee();

            if (employeeId != 0)
            {
                listOfEmployees = listOfEmployees.Where(s => s.id == employeeId).ToList();
            }

            return Json(listOfEmployees, JsonRequestBehavior.AllowGet);
        }

        public IEnumerable<Employee> GetEmployee()
        {
            IEnumerable<Employee> employees = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://masglobaltestapi.azurewebsites.net/api/");

                var responseTask = client.GetAsync("Employees");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Employee>>();
                    readTask.Wait();

                    employees = readTask.Result;
                }
                else
                {
                    employees = Enumerable.Empty<Employee>();
                    ModelState.AddModelError(string.Empty, "There was a problem accesing the server");
                }
            }

            return EmployeeBusiness.GetEmployees(employees);
        }
    }
}
