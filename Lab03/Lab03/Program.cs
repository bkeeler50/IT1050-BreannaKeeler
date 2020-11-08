using System;

{
    class Program
    {
        static void Main()
        {
            //initialise variables
            int speedLimit = 35;//speed limit
            int speed = 42;//speed


            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW!");
            }
        }
        
    }
   
}

/*The if single-selection statement and the while repetition statement are similar because they both perform an action 
 * only while a condition is true. They are different because while requires a repeated action that terminates when 
 * it ceases to be true, whereas if calls for a decision.*/
