using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExampleSolution_Easy_2
{
    class EmployeePromotion
    {
        List<string> employees;

        EmployeePromotion()
        {
            employees = new List<string>();
        }
        void AddEmployees()
        {
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            string name = "";
            do
            {
                name = Console.ReadLine();
                if (name != "")
                    employees.Add(name);
                else
                    break;
            } while (name != "");
        }
        void PrintPromotionPosition()
        {
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            string name = "";
            name = Console.ReadLine();
            int idx = employees.IndexOf(name);
            if (idx == -1)
                Console.WriteLine("Invalid name. There is no such employee in the promotion list");
            else
                Console.WriteLine("'" + name + "' is the the position " + (idx + 1) + " for promotion");
        }
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.AddEmployees();
            employeePromotion.PrintPromotionPosition();
            Console.ReadKey();
        }
    }


}
