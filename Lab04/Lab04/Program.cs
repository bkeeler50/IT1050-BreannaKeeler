/*The four basic elements of counter-controlled repetition are:
 * 1: A control variable or loop counter
 * 2: The control variable's initial value
 * 3: The control variable's increment applied during each iteration of the loop
 * 4: The loop continuation condition that determines if looping should continue. */

/*The While and For repetition statements are similar because they can both be used to implement counter controlled
 iteration. However, While repetition is typically used for sentinel controlled iteration and For is generally used
for counter-controlled iteration. */

/* It would be more appropriate to use a Do While statement over a While statement when you want your code to execute at least once.*/

using System;

namespace Lab04
{
   class ForLoop
    {
        static void Main()
        {
            /* for (int i = 1; i <= 100; ++i)
             {
                 if ((i % 2) == 0)
                 {
                     Console.WriteLine("It's Even.");
                 }
                 else
                 {
                     Console.WriteLine("It's Odd.");
                 }
             }*/





            /*  int i = 10;
              while (i < 21)
              {
                  Console.WriteLine(i);
              }
            This code just outputs 10, because there was no option for increment. In order to get the desired result, try:
             */

            /*  for (int i = 10; i < 21; ++i)
              {
                  Console.WriteLine(i);
              }*/





            /*for (int i = 0; i < 101; i++)
            Console.WriteLine(i);
            Console.WriteLine("********");

                        This code outputs all the numbers before finishing with a single line of asterisks. Instead:
                        */

            /*
             for (int i = 0; i < 101; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("********");
                }
             
             
             */
        }
    }
}


