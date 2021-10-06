using System;

namespace empcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_rate_per_hr = 20;
          int is_present = 1;
          int is_part_present = 2;
            int emp_hr = 0;
            int emp_wage = 0;
            int working_days_in_month = 20;
            
            int totalworkhr = 0;
            int totalwage = 0;
           // int maxworkhrs = 100;
            int day = 1;
            Random random = new Random();

            for (day = 1; day <= working_days_in_month; day++)
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
            Console.WriteLine("totalwage for a month is :" + totalwage);
 
        }
    }
}
