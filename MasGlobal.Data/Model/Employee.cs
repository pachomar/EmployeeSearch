namespace MasGlobal.Data.Model
{
    public class Employee : EntityBase
    {
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public double hourlySalary { get; set; }
        public double monthlySalary { get; set; }
        public double annualSalary { get; set; }
        public string contractType { get; set; }
        public string formattedHourlySalary { get; set; }
        public string formattedMonthlySalary { get; set; }
        public string formattedAnnualSalary { get; set; }

        public Employee()
        {

        }

        public Employee(Employee employee)
        {
            this.id = employee.id;
            this.name = employee.name;
            this.contractTypeName = employee.contractTypeName;
            this.roleId = employee.roleId;
            this.roleName = employee.roleName;
            this.roleDescription = employee.roleDescription;
            this.hourlySalary = employee.hourlySalary;
            this.monthlySalary = employee.monthlySalary;
        }

        public Employee(int id, string name, string contractTypeName, int roleId, string roleName, string roleDescription, double hourlySalary, double monthlySalary)
        {
            this.id = id;
            this.name = name;
            this.contractTypeName = contractTypeName;
            this.roleId = roleId;
            this.roleName = roleName;
            this.roleDescription = roleDescription;
            this.hourlySalary = hourlySalary;
            this.monthlySalary = monthlySalary;
        }
    }
}
