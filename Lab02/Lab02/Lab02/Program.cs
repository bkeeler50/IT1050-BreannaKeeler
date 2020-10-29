using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            int number2;

            int product;

            Console.Write("Enter first integer:");

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer:");

            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);

            Console.WriteLine("Hello World! From Breanna Keeler");

            Console.WriteLine("{0}\n{1}", "Hello World!", "From Breanna Keeler");
        }
    }
}


/*
a. At what point in the program does our C# Console Application begin execution?

It begins execution at the Main method: static void Main(string[] args).

b. What is the difference between an integer type variable and a double / floating-point variable?

An integer is a whole number, and double and floating-point variables are decimal/fractional numbers.

c. We can create blocks of code that we can call by name using a method.  Give an example of a method from Chapter 4.

public void Deposit(decimal depositAmount)
{
    if (depositAmount > 0.0m)
    {
        balance = value;
    }
}

d. Like we have types double and int, we can create our own custom types using Classes.  Each class has variables called instance variables or class members.  To read the value of an instance variable, we create method called a ____ accessor.  To assign a value to an instance variable, we use a method called a ____ accessor.

Get/Set.

e. What is the difference between a class and an object?  How many instances of a class can we create (please explain your answer)?

A class is basically a template for objects, and every program must have at least one class. An object belongs to a class, and you must instantiate at least one object in a class using either custom or default settings in order to call methods of the class. In theory, you can create as many objects or instances in a class as you like, but eventually you'll run out of data space, and it could get unwieldy to deal with that many objects.

*/