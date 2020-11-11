﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExampleSolution_Easy_1
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
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.AddEmployees();
            Console.ReadKey();
        }
    }


}
