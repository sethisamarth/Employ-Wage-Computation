using System;

namespace empcheck
{
    

    class Program
    {
      
        public static int  computeEmpWage(string company,int emp_rate_per_hr,int working_days_in_month,int maxworkhrs )
        {
            int emp_hr = 0; int totalworkhr = 0; int totalwage; int day = 1;


            Random random = new Random();

            while (day <= working_days_in_month  && totalworkhr <= maxworkhrs)
            {


                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        emp_hr = 8;
                        break;
                    case 2:
                        emp_hr = 4;

                        break;
                    default:
                        emp_hr = 0;

                        break;

                }

                totalworkhr = totalworkhr + emp_hr;
              
            }

            totalwage = totalworkhr * emp_rate_per_hr;
            Console.WriteLine(" totalwage of {0} is {1}:",company , totalwage);
            Console.WriteLine("totalworkhr for a month is :" + totalworkhr);
           return totalwage;
 
        }
         static void Main()
        {
           computeEmpWage("relince",20,20,100);
            computeEmpWage("dmart", 25, 30, 200);
        }
    }
}
