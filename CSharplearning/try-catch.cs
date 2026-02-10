using System;

namespace CSharplearning
{
    internal class try_catch
    {
        public try_catch()
        {
            //try
            //{
            //    Console.WriteLine("Enter number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //} catch {
            //    Console.WriteLine("You entered not a number");
            //}


            bool IsRunning = true;
            while (IsRunning)
            {
                try
                {
                    Console.Write("Enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    float result = 100 / num;

                    Console.Write("Result: " + result);
                    IsRunning = false;
                } catch (FormatException) {
                    Console.WriteLine("You entered not a number");
                } catch (DivideByZeroException){
                    Console.WriteLine("Your number is can`t be 0");
                } finally {
                    Console.WriteLine("Finally");
                }
            }
        }
    }
}
