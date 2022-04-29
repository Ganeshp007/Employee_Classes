using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Classes
{
     public class CalEmpwage
    {
        public const int Is_Parttime = 1;
        public const int Is_Fulltime = 2;

        private int Emp_Rate_Hr;
        private int NumOfWorkingDays;
        private int MaxHrPerMonth;
        private int Totalwage;
        private string CmpName;


        public CalEmpwage (String CmpName,int Emp_Rate_Hr,int NumOfWorkingDays,int MaxHrPerMonth)
        {
           this.CmpName = CmpName;
            this.MaxHrPerMonth = MaxHrPerMonth;
            this.Emp_Rate_Hr = Emp_Rate_Hr;
           this.NumOfWorkingDays = NumOfWorkingDays;
        }

        public void Find_Wage()
        {
            int Emp_Hr = 0;
            int Total_Emp_Hr = 0;
            int Total_NumOfDays = 1;
            Console.WriteLine("\nEmployee Record: -\n");
            while (Total_Emp_Hr <= MaxHrPerMonth && Total_NumOfDays <= NumOfWorkingDays)
            {   
                Random obj = new Random();
                int empcheck = obj.Next(0, 3);

                switch (empcheck)
                {
                    case Is_Fulltime: Emp_Hr = 8; break;

                    case Is_Parttime: Emp_Hr = 4; break;

                    default: Emp_Hr = 0; break;
                }

                Total_Emp_Hr += Emp_Hr;
                Console.WriteLine("Day:- " + Total_NumOfDays + " Empployee Hrs:- " + Emp_Hr);
                Total_NumOfDays++;
            }
            Totalwage = Total_Emp_Hr * this.Emp_Rate_Hr;
            
        }

        public string toString()
        {
            return "\nTotal Wage Of current Employee for Company " + this.CmpName + " is:- " + this.Totalwage;
        }

    }

    
}
