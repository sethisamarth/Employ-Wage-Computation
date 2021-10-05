using System;

namespace empcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_rate_per_hr = 20;
            int is_present = 1;
            int emp_hr = 0;
            int emp_wage = 0;

            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if(empcheck == is_present)
            {
                emp_hr = 8;
            }
            else
            {
                emp_hr = 0;
            }
            emp_wage = emp_hr * emp_rate_per_hr;
            Console.WriteLine("emp_wage :" + emp_wage);
            
        }
    }
}
