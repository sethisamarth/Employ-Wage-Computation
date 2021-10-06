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
            Random random = new Random();

            int empcheck = random.Next(0 , 3);
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

            emp_wage = emp_hr * emp_rate_per_hr;
            Console.WriteLine("emp_wage :" + emp_wage);
            Console.ReadLine();
        }
    }
}
