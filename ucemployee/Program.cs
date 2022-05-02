using System;

namespace uc1empstatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent;
            int isAbsent;
            Random random = new Random();
            int randomcheck = random.Next(2);
            if (randomcheck == 1)
            {
                Console.WriteLine("the employee  present");
            }
            else
            {
                Console.WriteLine("the employee absent");
            }
        }
    }
}