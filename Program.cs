namespace bd_dz
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public Region(int regionId, string regionName)
        {
            RegionId = regionId;
            RegionName = regionName;
        }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }
        public Country(int countryId, string countryName, int regionId)
        {
            CountryId = countryId;
            CountryName = countryName;
            RegionId = regionId;
           
        }
    }

    public class Location
    {
        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int CountryId { get; set; }
        public Location(int locationId, string streetAddress, string postalCode, string city, string stateProvince, int countryId)
        {
            LocationId = locationId;
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
            StateProvince = stateProvince;
            CountryId = countryId;

        }
    }

    public class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public Job(int jobId, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            JobId = jobId;
            JobTitle = jobTitle;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int ManagerId { get; set; }
        public int LocationId { get; set; }
        public Department(int departmentId, string departmentName, int managerId, int locationId)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            ManagerId = managerId;
            LocationId = locationId;
        }
    }

    public class JobHistory
    {
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public JobHistory(int employeeId, DateTime startDate, DateTime endDate, int jobId, int departmentId)
        {
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            JobId = jobId;
            DepartmentId = departmentId;
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int JobId { get; set; }
        public decimal Salary { get; set; }
        public decimal? CommissionOct { get; set; }
        public int? ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public Employee(int employeeId, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, int jobId, decimal salary, decimal? commissionOct, int? managerId, int departmentId)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            HireDate = hireDate;
            JobId = jobId;
            Salary = salary;
            CommissionOct = commissionOct;
            ManagerId = managerId;
            DepartmentId = departmentId;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Region> regions = new List<Region>
{
    new Region(1, "Region 1"),
    new Region(2, "Region 2"),

};

            List<Country> countries = new List<Country>
{
    new Country(1, "Country 1", 1),
    new Country(2, "Country 2", 1),

};

            List<Location> locations = new List<Location>
{
    new Location(1, "Street 1", "12345", "City 1", "State 1", 1),
    new Location(2, "Street 2", "23456", "City 2", "State 2", 2),

};

            List<Job> jobs = new List<Job>
{
    new Job(1, "IT_PROG", 5000, 10000),
    new Job(2, "SALES_REP", 6000, 12000)
    // Add more jobs as needed
};

            List<Department> departments = new List<Department>
{
   new Department(1, "Dep1", 1, 1),
    new Department(2, "Department2 2", 2, 2),
    new Department(50, "Department3 50", 3, 3),
    new Department(80, "Department4 80", 4, 4)

};

            List<JobHistory> jobHistories = new List<JobHistory>
{
   new JobHistory(1, DateTime.Now.AddDays(-365), DateTime.Now, 1, 1),
    new JobHistory(2, DateTime.Now.AddDays(-365), DateTime.Now, 2, 2),
    new JobHistory(3, DateTime.Now.AddDays(-365), DateTime.Now, 1, 50),
    new JobHistory(4, DateTime.Now.AddDays(-365), DateTime.Now, 2, 80)

};

            List<Employee> employees = new List<Employee>
{
    new Employee(1, "John", "Doe", "john.doe@example.com", "123.456.7890", new DateTime(2022, 1, 1), 1, 5000, null, null, 1),
    new Employee(2, "Jane", "Smith", "jane.smith@example.com", "987.654.3210", new DateTime(2022, 1, 15), 2, 6000, null, 1, 2),
    new Employee(3, "David", "Brown", "david.brown@example.com", "111.122.3333", new DateTime(2022, 2, 1), 1, 7000, null, null, 50),
    new Employee(4, "David%", "Lee", "david.lee@example.com", "444-555-6666", new DateTime(2022, 2, 15), 2, 8000, null, null, 80),
    new Employee(5, "Annam", "Johnson", "anna.johnson@example.com", "777-888-9999", new DateTime(2022, 3, 1), 1, 9000, 0.05m, null, 1),
    new Employee(6, "Hannah", "Williams", "hannah.williams@example.com", "000-111-2222", new DateTime(2022, 3, 15), 2, 10000, 0.03m, null, 2)
};  
            Console.WriteLine("------------------");
            var employeesWithSalaryBetween8000And9000 = employees.Where(e => e.Salary >= 8000 && e.Salary <= 9000)
                                                                  .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Salary = e.Salary });
            PrintEmployees("Employees with salary between 8000 and 9000:", employeesWithSalaryBetween8000And9000);
            var employeesWithPercentInName = employees.Where(e => e.FirstName.Contains("%") || e.LastName.Contains("%"))
                                                      .Select(e => new { FullName = $"{e.FirstName} {e.LastName}" });
            PrintEmployees("Employees with '%' in their name:", employeesWithPercentInName);
            var managerIds = employees.Select(e => e.ManagerId).Distinct().ToList();
            Console.WriteLine("List of all manager IDs:");
            foreach (var managerId in managerIds)
            {
                Console.WriteLine(managerId);
            }
            var employeesWithLongName = employees.Where(e => (e.FirstName.Length + e.LastName.Length) > 10)
                                                 .Select(e => new { FullName = $"{e.FirstName} {e.LastName}" });
            PrintEmployees("Employees with name length greater than 10 characters:", employeesWithLongName);
            var employeesWithBInName = employees.Where(e => e.FirstName.ToLower().Contains("b") || e.LastName.ToLower().Contains("b"))
                                                .Select(e => new { FullName = $"{e.FirstName} {e.LastName}" });
            PrintEmployees("Employees with 'b' in their name:", employeesWithBInName);
            var employeesWithTwoAsInName = employees.Where(e => e.FirstName.Count(c => c == 'a') + e.LastName.Count(c => c == 'a') >= 2)
                                                     .Select(e => new { FullName = $"{e.FirstName} {e.LastName}" });
            PrintEmployees("Employees with at least two 'a' in their name:", employeesWithTwoAsInName);
            var employeesWithSalaryMultipleOf1000 = employees.Where(e => e.Salary % 1000 == 0)
                                                              .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Salary = e.Salary });
            PrintEmployees("Employees with salary multiple of 1000:", employeesWithSalaryMultipleOf1000);
            var firstThreeDigitPhoneNumber = employees.Select(e => e.PhoneNumber.Split('.')[0])
                                                      .FirstOrDefault(num => num.Length == 3 && num.All(char.IsDigit));
            Console.WriteLine($"First 3-digit number in an employee's phone number: {firstThreeDigitPhoneNumber}");
            var departmentsWithMoreThanOneWord = departments.Where(d => d.DepartmentName.Split(' ').Length > 1)
                                                             .Select(d => d.DepartmentName.Split(' ')[0]);
            Console.WriteLine("First word from department names with more than one word:");
            foreach (var departmentName in departmentsWithMoreThanOneWord)
            {
                Console.WriteLine(departmentName);
            }
            var employeesWithoutFirstAndLastLetter = employees.Select(e => new { FullName = e.FirstName.Substring(1, e.FirstName.Length - 2) });
            PrintEmployees("Employees with first and last letters removed from their name:", employeesWithoutFirstAndLastLetter);
            var employeesWithLastLetterMAndNameLengthGreaterThan5 = employees.Where(e => e.FirstName.ToLower().Last() == 'm' && (e.FirstName.Length + e.LastName.Length) > 5)
                                                                              .Select(e => new { FullName = $"{e.FirstName} {e.LastName}" });
            PrintEmployees("Employees with last letter 'm' in their name and name length greater than 5:", employeesWithLastLetterMAndNameLengthGreaterThan5);
            var cityWithLowestTotalSalary = employees.Join(departments,
                                    e => e.DepartmentId,
                                    d => d.DepartmentId,
                                    (e, d) => new { Employee = e, Department = d })
                                .Join(locations,
                                    ed => ed.Department.LocationId,
                                    l => l.LocationId,
                                    (ed, l) => new { Employee = ed.Employee, Location = l })
                                .GroupBy(join => join.Location.City)
                                .Select(group => new { City = group.Key, TotalSalary = group.Sum(join => join.Employee.Salary) })
                                .OrderBy(s => s.TotalSalary)
                                .First().City;
            Console.WriteLine($"City where employees earn the least in total: {cityWithLowestTotalSalary}");
            var employeesWithManagerEarningMoreThan15000 = employees.Where(e => e.ManagerId != null && employees.Any(m => m.EmployeeId == e.ManagerId && m.Salary > 15000))
                                                                     .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", ManagerId = e.ManagerId });
            PrintEmployees("Employees whose manager earns more than 15000:", employeesWithManagerEarningMoreThan15000);
            var departmentsWithNoEmployees = departments.Where(d => !employees.Any(e => e.DepartmentId == d.DepartmentId))
                                                         .Select(d => d.DepartmentName);
            Console.WriteLine("Departments with no employees:");
            foreach (var departmentName in departmentsWithNoEmployees)
            {
                Console.WriteLine(departmentName);
            }
            var employeesWhoAreNotManagers = employees.Where(e => e.ManagerId == null)
                                                      .Select(e => new { FullName = $"{e.FirstName} {e.LastName}" });
            PrintEmployees("Employees who are not managers:", employeesWhoAreNotManagers);
            var managersWithMoreThan6Employees = employees.GroupBy(e => e.ManagerId)
                                                           .Where(group => group.Key != null && group.Count() > 6)
                                                           .SelectMany(group => group)
                                                           .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", ManagerId = e.ManagerId });
            PrintEmployees("Managers with more than 6 employees under them:", managersWithMoreThan6Employees);
            var employeesInITDepartment = employees.Join(departments, e => e.DepartmentId, d => d.DepartmentId, (e, d) => new { Employee = e, Department = d })
                                                    .Where(join => join.Department.DepartmentName == "IT")
                                                    .Select(join => new { FullName = $"{join.Employee.FirstName} {join.Employee.LastName}" });
            PrintEmployees("Employees who work in the IT department:", employeesInITDepartment);
        }
        static void PrintEmployees(string header, IEnumerable<dynamic> employees)
        {
            Console.WriteLine(header);
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName}");
            }
            Console.WriteLine("------------------");
        }
    }
}
