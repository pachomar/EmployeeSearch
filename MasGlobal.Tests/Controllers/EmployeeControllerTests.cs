using MasGlobal.Controllers;
using MasGlobal.Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MasGlobal.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTests
    {
        [TestMethod]
        public void GetAllEmployeesTest()
        {
            EmployeeController controller = new EmployeeController();
            IEnumerable<Employee> response = controller.GetEmployee();

            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Count());
        }
    }
}
