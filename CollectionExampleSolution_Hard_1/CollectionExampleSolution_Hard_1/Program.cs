using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionExampleSolution_Hard_1
{
    class EmployeeCRUD
    {
        Dictionary<int, Employee> employees;
        EmployeeCRUD()
        {
            employees = new Dictionary<int, Employee>();
        }
        void AddEmployees()
        {
            int flag = 0;
            Employee employee;
            do
            {
                employee = new Employee();
                employee.TakeEmployeeDetailsFromUser();
                if (employees.ContainsKey(employee.Id))
                    Console.WriteLine("Duplicate employee id. Data not inserted...");
                else
                    employees.Add(employee.Id, employee);
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                flag = Convert.ToInt32(Console.ReadLine());
            } while (flag != 0);
        }
        void PrintEmployees()
        {
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
                Console.WriteLine("-----------------------");
            }
        }
        Employee GetEmployeeWithId()
        {
            Employee employee = null;
            Console.WriteLine("Please enter the employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            if (employees.ContainsKey(id))
                employee = employees[id];
            return employee;
        }
        void PrintEmployee()
        {
            Employee employee = GetEmployeeWithId();
            if(employee!=null)
            {
                Console.WriteLine("The employee details:");
                Console.WriteLine(employee);
            }
            else
                Console.WriteLine("No such employee");
        }
        void ModifyEmployee()
        {
            Employee employee = GetEmployeeWithId();
            if (employee != null)
            {
                Console.WriteLine("The employee details:");
                Console.WriteLine(employee);
                Console.WriteLine("Please enter the updated employee details");
                Console.WriteLine("Please enter the employee name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Please enter the employee age");
                employee.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the employee salary");
                employee.Salary = Convert.ToDouble(Console.ReadLine());
                employees[employee.Id] = employee;
            }
            else
                Console.WriteLine("No such employee");
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Please enter the option");
                Console.WriteLine("1. Add an employee");
                Console.WriteLine("2. Modify an employee detail");
                Console.WriteLine("3. Print all employee's details");
                Console.WriteLine("4. Print an employee detail");
                Console.WriteLine("5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployees();
                        break;
                    case 2:
                        ModifyEmployee();
                        break;
                    case 3:
                        PrintEmployees();
                        break;
                    case 4:
                        PrintEmployee();
                        break;
                    case 5:
                        Console.WriteLine("Bye bye");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            } while (choice!=5);
        }
        static void Main(string[] args)
        {
            EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            employeeCRUD.PrintMenu();
            Console.ReadKey();
        }
    }
}
