﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Part_Time = 2;
            int Is_Full_Time = 1;
            int Wage_Per_Hr = 20;
            int Daily_Wage = 0;
            int WorkingHrs = 0;
            Random r = new Random();
            int check = r.Next(0, 3);
            if (Is_Full_Time == check)
                WorkingHrs = 8;
            if (Is_Part_Time == check)
                WorkingHrs = 4;
            else
                WorkingHrs = 0;
            Daily_Wage = WorkingHrs + Wage_Per_Hr;
            Console.WriteLine(Daily_Wage);
            Console.ReadLine();
        }
    }
}