using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double RatePerHour { get; set; }
        public double TotalHoursWorked { get; set; }
        public double BasicSalary { get; private set; }

        public void ComputeSalary()
        {
            BasicSalary = RatePerHour * TotalHoursWorked;
        }
    }
}
