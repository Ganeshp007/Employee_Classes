using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Classes
{
    internal class CalEmpwage
    {


        public static int TotalEmpwage()
        {

            int Is_Fulltime = 1;
            int Is_Parttime = 2;
            int Emp_Rate_Hr = 20;
            int Emp_Hr = 0;
            int Emp_wage = 0;
            Random obj = new Random();
            int empcheck = obj.Next(0, 3); //it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

            if (empcheck == Is_Fulltime)
            {
                Console.WriteLine("Employee is Fulltime");
                Emp_Hr = 8;
            }
            else if (empcheck == Is_Parttime)
            {
                Console.WriteLine("Employee is Parttime");
                Emp_Hr = 4;
            }
            else
            {   Emp_Hr = 0;
                Console.WriteLine("Employee is Absent");
            }

            Emp_wage = Emp_Rate_Hr * Emp_Hr;
            Console.WriteLine("\nDailywage of current Empolyee is :- " + Emp_wage);

            return Emp_wage;
            

        }
    }
}
