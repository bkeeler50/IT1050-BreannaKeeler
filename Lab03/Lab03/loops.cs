using System;

namespace Lab03
{
    public class addloop
    {
        public static void Main()
        {
            int add1 = 1;

            while (add1 < 10)
            {
                add1 = 1 + add1;
                Console.WriteLine(add1);
            }

            int minus5 = 60;

            while (minus5 > 20)
            {
                minus5 = minus5 - 5;
                Console.WriteLine(minus5);
            }

            int reach20 = 10;

            while (reach20 < 20)
            {
                reach20 = reach20 + 2;
                Console.WriteLine(reach20);
            }
        }
    }
}