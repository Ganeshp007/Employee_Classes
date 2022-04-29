using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Classes
{
    internal class CalEmpwage
    {
 
            public const int Is_Fulltime = 1;
            public const int Is_Parttime = 2;
            public const int Emp_Rate_Hr = 20;

            public static int Emp_Hr = 0;
            public static int Emp_wage = 0;

        public static int CalEmpHr()
        {
            
            Random obj = new Random();
            int empcheck = obj.Next(0, 3); //it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

            if (empcheck == Is_Fulltime)
            {
                Console.WriteLine("Employee is Fulltime\n");
                Emp_Hr = 8;
            }
            else if (empcheck == Is_Parttime)
            {
                Console.WriteLine("Employee is Parttime\n");
                Emp_Hr = 4;
            }
            else
            { Emp_Hr = 0;
                Console.WriteLine("Employee is Absent\n");
            }

            Console.WriteLine("Total working Hr of EMployee:- "+Emp_Hr);
            return Emp_Hr;


        }

         public static int Calwage()
        {
            Emp_wage = Emp_Rate_Hr * Emp_Hr;
            Console.WriteLine("\nWage of current Empolyee is :- " + Emp_wage);

            return Emp_wage;

        }
          
    }
}
