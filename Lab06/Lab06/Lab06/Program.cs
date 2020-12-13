/*
 * 
 * A one-dimensional array p contains four elements.  
 * The array access expressions to access each of the elements 
 * in p are p[0], p[1], p[2], and p[3].

*/

using System;

namespace Lab06
{
    class Seasons
    {
        string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };

        foreach (string i in seasons)
            {
            Console.WriteLine(i);
            }
     }

class CalendarArray
    {
        static void Main()
        {
            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            

            Console.WriteLine($"{"Index"}");

            for (int i = 0; i < months.Length; ++i)
            {
                Console.WriteLine(months[i]);
            }

        string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

        int i = 0;
       /* while (i < names.Length)
        {
            Console.WriteLine(names[i]);
            i++
        }*/
         foreach(string i in names)
        {
            Console.WriteLine(i);
        }

    }
}


    class Random
    {
       Random random = new Random();
 
       int randomNumber size = 1000;

        int[] arr = new int[size];

        foreach (int i in arr)
        {
        randomNumber = random.Next(0, 100);
       /* Console.WriteLine(i);*/
       Console.WriteLine("{0,2}. {1}", i, names[i]);
        }
    }
}
