using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExampleSolution_Medium_2
{
  
    class EmployeePromotion
    {
        Dictionary<int, Employee> employees;
        List<Employee> employeesList;
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
                if (employees.ContainsKey(employee.Id))
                    Console.WriteLine("Duplicate employee id. Data not inserted...");
                else
                    employees.Add(employee.Id, employee);
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                flag = Convert.ToInt32(Console.ReadLine());
            } while (flag != 0);
        }
        void ConvertToList()
        {
            employeesList = employees.Values.ToList();
        }
        void SortAndPrintEmployees()
        {
            Console.WriteLine("The sorted employee list");
            employeesList.Sort();
            foreach (var item in employeesList)
            {
                Console.WriteLine(item);
                Console.WriteLine("-----------------------");
            }
        }
        void PrintEmployee()
        {
            Console.WriteLine("Please enter the employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                Employee employee = employeesList.Where(e => e.Id == id).First();
                Console.WriteLine("The employee details:");
                Console.WriteLine(employee);
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine("No such employee");
            }

        }
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.AddEmployees();
            employeePromotion.ConvertToList();
            employeePromotion.SortAndPrintEmployees();
            employeePromotion.PrintEmployee();
            Console.ReadKey();
        }
    } 
}
