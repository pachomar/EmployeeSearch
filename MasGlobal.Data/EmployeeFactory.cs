using MasGlobal.Data.Model;
using System;

namespace MasGlobal.Data.Factory
{
    public abstract class EmployeeFactory
    {
        public abstract IEmployeeFactory GetEmployee(Employee item);
    }

    public class ConcreteEmployeeFactory : EmployeeFactory
    {
        public override IEmployeeFactory GetEmployee(Employee item)
        {
            switch (item.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new EmployeePerHour(item.id, item.name, item.contractTypeName, item.roleId, item.roleName, item.roleDescription, item.hourlySalary, item.monthlySalary);
                case "MonthlySalaryEmployee":
                    return new EmployeePerMonth(item.id, item.name, item.contractTypeName, item.roleId, item.roleName, item.roleDescription, item.hourlySalary, item.monthlySalary);
                default:
                    throw new ApplicationException(string.Format("Employee '{0}' cannot be created", item.contractTypeName));
            }
        }
    }
}
