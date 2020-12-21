using MasGlobal.Data.Factory;
using MasGlobal.Data.Model;
using System.Collections.Generic;

namespace MasGlobal.Business
{
    public static class EmployeeBusiness
    {
        public static IEnumerable<Employee> GetEmployees(IEnumerable<Employee> listOfEmployees)
        {
            EmployeeFactory factory = new ConcreteEmployeeFactory();
            List<Employee> employeeList = new List<Employee>();

            foreach (Employee emp in listOfEmployees)
            {
                IEmployeeFactory employee = factory.GetEmployee(emp);
                emp.annualSalary = employee.CalculateAnnualSalary(emp.contractTypeName);
                emp.contractType = emp.contractTypeName.Contains("Hourly") ? "Hourly" : "Monthly";
                emp.formattedHourlySalary = emp.hourlySalary.ToString("C");
                emp.formattedMonthlySalary = emp.monthlySalary.ToString("C");
                emp.formattedAnnualSalary = emp.annualSalary.ToString("C");
                employeeList.Add(emp);
            }

            return (IEnumerable<Employee>)employeeList;
        }
    }
}
