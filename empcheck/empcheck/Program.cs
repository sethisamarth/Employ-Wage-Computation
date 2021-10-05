using System;

namespace empcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_present = 1;
            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if(empcheck == is_present)
            {
                Console.WriteLine("employ is present");
            }
            else
            {
                Console.WriteLine("employ is absent");
            }
        }
    }
}
