using System;
using System.Linq.Expressions;
using CSharplearning;

namespace CSharplearning
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Тема 1: Variables and data types");
            //new VariablesAndTypes();

            //Console.WriteLine("Тема 2: Математичні операції");
            //new Math_operation();

            //Console.WriteLine("Тема 3: Умовні оператори");
            //new Conditional_Statements();

            //Console.WriteLine("Тема 4: Switch_case");
            //new Switch_case();

            //Console.WriteLine("Тема 5: Цикли");
            //new Loops();

            //Console.WriteLine("Тема 6: Arrays");
            //new Arrays();

            //Console.WriteLine("Тема 7: ForEachEL");
            //new ForEachEL();

            //Console.WriteLine("Тема 8: Generics");
            //new Generics();

            //Console.WriteLine("Тема 9: Functions");
            //new functionsik();

            //Console.WriteLine("Тема 10: Strings And Files");
            //new StringsAndFiles();

            //Console.WriteLine("Тема 11: Try_catch");
            //new try_catch();



            Console.WriteLine("Тема 11: OOP");
            OOP Bot = new OOP();
            Bot.SetValues("Bot", 250, 1500, 2.0F, new byte[] { 0, 0, 0 });  // for private - треба юзати функції для того класу
            //Bot.name = "Bot";
            //Bot.weight = 250;
            //Bot.power = 1500;
            //Bot.version = 2.0F;
            //Bot.coordinates = new byte[] {0,0,0};
                                                            //public - Бо легко будь де можна доступитися
            //Console.WriteLine("Name: " + Bot.name);
            //Console.WriteLine("Weight: " + Bot.weight);
            //Console.WriteLine("Version: " + Bot.version);
            //Console.WriteLine("Coordinates: " + string.Join(", ", Bot.coordinates));

            Bot.printValues();


            OOP Killer = new OOP();
            Killer.SetValues("Killer", 300, 15000, 8.0F, new byte[] { 2, 2, 245 });   // for private - треба юзати функції для того класу
            //Killer.name = "Killer";
            //Killer.weight = 300;
            //Killer.power = 15000;
            //Killer.version = 8.0F;
            //Killer.coordinates = new byte[] { 2, 2, 245 };
                                                            //public - Бо легко будь де можна доступитися
            //Console.WriteLine("Name: " + Killer.name);
            //Console.WriteLine("Weight: " + Killer.weight);
            //Console.WriteLine("Version: " + Killer.version);
            //Console.WriteLine("Coordinates: " + string.Join(", ", Killer.coordinates));

            Killer.printValues();

        }
    }
};