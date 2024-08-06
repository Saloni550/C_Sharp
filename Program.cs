using System;
using System.Collections.Generic;

// Single Responsibility Principle
namespace SolidApplication
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }

    // Interface Segregation Principle
    public interface IFax
    {
        bool FaxContent(string content);
    }

    public interface IPrint
    {
        bool PrintContent(string content);
    }

    public interface IScan
    {
        bool ScanContent(string content);
    }

    public interface IPhotoCopy
    {
        bool PhotoCopyContent(string content);
    }

    public class HPLaserJet : IFax, IPrint, IScan, IPhotoCopy
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photocopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }

    // Open/Closed Principle
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        protected Employee() { }

        protected Employee(int id, string name, string employeeType)
        {
            ID = id;
            Name = name;
            EmployeeType = employeeType;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", ID, Name);
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }

        public PermanentEmployee(int id, string name) : base(id, name, "permanent") { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }

        public TemporaryEmployee(int id, string name) : base(id, name, "temporary") { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
    }

    // Dependency Inversion Principle
    public interface IDataAccessLayer
    {
        void Save(object details);
    }

    public class DataAccessLayer : IDataAccessLayer
    {
        public void Save(object details)
        {
            // Perform save
            Console.WriteLine("Details saved to the database.");
        }
    }

    public class BusinessLogicLayer
    {
        private readonly IDataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public void Save(object details)
        {
            _dataAccessLayer.Save(details);
        }
    }

    // Liskov Substitution Principle
    public class EmployeeDemo
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new PermanentEmployee(1, "John Doe"),
                new TemporaryEmployee(2, "Jane Smith")
            };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}'s bonus: {employee.CalculateBonus(1000)}");
            }

            IDataAccessLayer dataAccessLayer = new DataAccessLayer();
            BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer(dataAccessLayer);
            businessLogicLayer.Save(new { Name = "Sample Data" });

            HPLaserJet printer = new HPLaserJet();
            printer.FaxContent("Faxing content...");
            printer.PhotoCopyContent("Photocopying content...");
            printer.PrintContent("Printing content...");
            printer.ScanContent("Scanning content...");
            Console.Read();
        }
    }
}
