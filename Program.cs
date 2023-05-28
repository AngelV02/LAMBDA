using System;
using System.Collections.Generic;
using System.Linq;

namespace LAMBDA
{
    // Create the Employee class with properties
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creates a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Davis" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "Robert", LastName = "Taylor" },
                new Employee { Id = 8, FirstName = "Emma", LastName = "Clark" },
                new Employee { Id = 9, FirstName = "Joe", LastName = "Harris" },
                new Employee { Id = 10, FirstName = "Olivia", LastName = "Anderson" }
            };

            // Creates new list of employees with the first name "Joe" using foreach loop
            List<Employee> joeEmployees = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }

            // Creates new list of employees with the first name "Joe" using lambda expression
            List<Employee> joeEmployeesLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Creates  new list of employees with Id greater than 5 using lambda expression
            List<Employee> idGreaterThan5Employees = employees.Where(employee => employee.Id > 5).ToList();

            // Print the employees with the first name "Joe" using foreach loop
            Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
            foreach (Employee employee in joeEmployees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine();

            // Print the employees with the first name "Joe" using lambda expression
            Console.WriteLine("Employees with the first name 'Joe' (lambda expression):");
            foreach (Employee employee in joeEmployeesLambda)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine();

            // Print the employees with Id greater than 5 using lambda expression
            Console.WriteLine("Employees with Id greater than 5:");
            foreach (Employee employee in idGreaterThan5Employees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
