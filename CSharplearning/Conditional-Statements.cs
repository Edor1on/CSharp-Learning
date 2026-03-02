using System;

namespace CSharplearning
{
    internal class Conditional_Statements
    {
        public Conditional_Statements()
        {
            // умовні конструкції
            Console.Write("Enter number: ");
            int user_number = Convert.ToInt32(Console.ReadLine());
            bool IsHasCar = false;
            if (user_number >= 5 && !IsHasCar) // || - або (хочаб одне було коректним)
            {
                Console.WriteLine("He has car");
                Console.WriteLine("Number is five or more");
            }
            else if (user_number == 4)
            {
                Console.WriteLine("Is Else_if and == 4");
            }
            else if (user_number == 3)
            {
                Console.WriteLine("Is Else_if and == 3");
            }
            else if (user_number == 2)
            {
                Console.WriteLine("Is Else_if and == 2");
            }
            else if (user_number == 1)
            {
                Console.WriteLine("Is Else_if and == 1");
            }
            else
            {
                Console.WriteLine("low than 1");
            }


            // Practice

            Console.WriteLine("Enter your name: ");
            string user_name = Console.ReadLine();

            if (user_name == "Admin")
            {
                Console.WriteLine($"Good, your name is {user_name}");
                Console.WriteLine("Enter your age");
                short age = Convert.ToInt16(Console.ReadLine());
                if (age > 0 && age < 120)
                {
                    Console.WriteLine($"All is correct, your name is {user_name} and age is {age}");
                }
                else
                {
                    Console.WriteLine("Error");
                    age = 0;
                }
            }
            else
            {
                Console.WriteLine("Isn`t correct");
            }
        }
    }
}
