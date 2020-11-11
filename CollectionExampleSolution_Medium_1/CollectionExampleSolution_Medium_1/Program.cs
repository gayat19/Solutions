using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExampleSolution_Medium_1
{
    class EmployeePromotion
    {
        Dictionary<int, Employee> employees;
        EmployeePromotion()
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
                if(employees.ContainsKey(employee.Id))
                    Console.WriteLine("Duplicate employee id. Data not inserted...");
                else
                    employees.Add(employee.Id, employee);
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                flag = Convert.ToInt32(Console.ReadLine());
            } while (flag!=0);
        }
        void PrintEmployee()
        {
            Console.WriteLine("Please enter the employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            if (employees.ContainsKey(id))
                Console.WriteLine(employees[id]);
            else
                Console.WriteLine("There is no such employee");
        }
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.AddEmployees();
            employeePromotion.PrintEmployee();
            Console.ReadKey();
        }
    }
}
