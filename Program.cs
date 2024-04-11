
/* NOTESPACE
 * 
 * METHOD OVERRIDING: If the same method is present
 * in both the base class and the derived class, the
 * method in the derived class overrides the method in the 
 * base class. This is called method overriding in C#.
 * 
 * use keyword OVERRIDE.
 * 
 * Virtual: allows the method to be overriden by the derived class.
 * 
 * Override: Indicates the method is overriding the method from the base class.
 * 
 * Base keyword: This is used to access members of the base
 * class 
 *
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */


namespace Unit8InheritanceExample1
{
    public class Person  // Base class.
    {
        public string? name;
        public string? socialSecurityNumber;
        public int age;

        public virtual string Info()
        {
            return $"Name: {this.name}, SSN: {this.socialSecurityNumber}";
        }

        public string ReturnAge()
        {
            return $"My Age: {this.age}";
        }
    }

    sealed class Employee : Person // Child class. Inherits from class "Person," giving Employee class acces to all Person fields.
    {
        public string? jobTitle;
        public double salary;
    }

    sealed class Student : Person // Inherits fields from class "Person", giving Student class access to all Person fields. (Child class)
    {
        public int id;
        public double gpa;

        public override string Info()
        {
            return $"Student Name: {this.name}, SSN: {this.socialSecurityNumber}, GPA: {this.gpa} - {base.ReturnAge()}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.name = "Good Worker";
            employee.socialSecurityNumber = "12345";
            employee.jobTitle = "Test";
            employee.salary = 100;
            Console.WriteLine($"{employee.Info()}");

            Person person = new Person();
            person.name = "Basic person";
            person.socialSecurityNumber = "12345"; // Access to employee class-specific fields is restricted.
            Console.WriteLine($"{person.Info()}");

            Student student = new Student();
            student.id = 1;
            student.gpa = 4.0;
            student.name = "Student"; // Inherited from Person class.
            student.socialSecurityNumber = "12345"; // Also inherited from Person class.
            Console.WriteLine($"{student.Info()}");
        }
    }
}