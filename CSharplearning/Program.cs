using System;
using System.Linq.Expressions;
using CSharplearning;
using System.Collections.Generic;

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



            //Console.WriteLine("Тема 11: OOP");

            //RobotOOP Bot = new RobotOOP("Bot", 250, 1500, 2.0F, new byte[] { 0, 0, 0 });
            //Bot.SetValues("Bot", 250, 1500, 2.0F, new byte[] { 0, 0, 0 });  // for private - треба юзати функції для того класу    також через конструктор
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

            //Bot.printValues(); - не потрібне через контруктор


            //RobotOOP Killer = new RobotOOP("Killer", 300, 15000, 8.0F, new byte[] { 2, 2, 245 });
            //Killer.SetValues("Killer", 300, 15000, 8.0F, new byte[] { 2, 2, 245 });   // for private - треба юзати функції для того класу   також через конструктор для зручності
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

            //Killer.printValues();  - не потрібне через контруктор

            //RobotOOP Adrian = new RobotOOP();

            //RobotOOP.value = 15;
            //Console.WriteLine(RobotOOP.value);

            //RobotOOP.PrintSOmeText();

            //RobotOOP.PrintCount();

            //RobotOOP Botosu = new RobotOOP();
            //Botosu.Weight = -3;
            ////Botosu.Width = 135; // помилка бо set є private
            //Console.WriteLine(Botosu.Width); // бо get is publiv
            //Console.WriteLine($"This is not courect value of weight: {Botosu.Weight}, try again");

            //RobotOOPKilljoy qwerty = new RobotOOPKilljoy();

            //qwerty.printValues();  // has access

            //qwerty.Damage = 20;
            //Console.WriteLine(qwerty.Damage);

            ////Killer.Damage();  бо батько не наслідує


            //RobotOOPKilljoy type_5 = new RobotOOPKilljoy("TYPE_5", 300, 15000, 8.0F, new byte[] { 221, 34, 245 }, 15000);
            //type_5.Lazer();

            RobotOOP Adolf = new RobotOOP("Adolf");
            RobotOOPKilljoy Killer = new RobotOOPKilljoy("Killer", 300, 15000, 8.0F, new byte[] { 2, 2, 245 }, 25000);


            //RobotOOP[] wert = new RobotOOP[] {
            //    Adolf, Killer, new RobotOOP()
            //};

            List<RobotOOP> bots = new List<RobotOOP>();
            {
                bots.Add(new RobotOOP("Alex"));
                bots.Add(Adolf);
                bots.Add(Killer);

                RobotOOPKilljoy Killer1 = null;
                foreach(RobotOOP el in bots)
                {
                    if (el.Name == "Killer") {
                        Killer1 = el as RobotOOPKilljoy;
                        Killer1.Lazer();
                    }
                    Console.WriteLine(el is RobotOOPKilljoy);
                }
            }
        }
    }
};