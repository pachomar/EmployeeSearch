using MasGlobal.Data.Factory;
using MasGlobal.Data.Model;

namespace MasGlobal.Data
{
    public class EmployeePerHour : Employee, IEmployeeFactory
    {
        public EmployeePerHour(int id, string name, string contractTypeName, int roleId, string roleName, string roleDescription, double hourlySalary, double monthlySalary) 
            : base(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary)
        {

        }

        public double CalculateAnnualSalary(string contractType)
        {
            return 120 * hourlySalary * 12;
        }
    }

    public class EmployeePerMonth : Employee, IEmployeeFactory
    {
        public EmployeePerMonth(int id, string name, string contractTypeName, int roleId, string roleName, string roleDescription, double hourlySalary, double monthlySalary) 
            : base(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary)
        {

        }

        public double CalculateAnnualSalary(string contractType)
        {
            return monthlySalary * 12;
        }
    }
}
