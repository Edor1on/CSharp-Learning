using System;


namespace CSharplearning
{
    internal class VariablesAndTypes
    {
        public VariablesAndTypes()
        {
            //змінні та типи даних

            int number = 10;
            Console.WriteLine(number);
            number = 20;
            Console.WriteLine("Result: " + number);


            byte byte1 = 255; // від 0 до 255
            short short1 = 32767; // від -32 768 до 32 767
            ushort ushort1 = 1; // 	від 0 до 65 535
            int int1 = 0;
            uint only_positive = 15; // тільки додатні там де "u"
            long long1 = 0;
            ulong ulong1 = 1;

            // числа з крапкою
            float float1 = 1.56765f;
            double double1 = 1.923746012f;

            // text
            string string1 = "Hello";
            char char1 = 'A';

            // булеани
            bool istrue = true;


            int user1, user2;

            // особливі типи
            object user3;
            dynamic user4;

            user1 = Convert.ToInt32(Console.ReadLine());
            user2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + user1 + "; Result: " + user2);


        }    
    }

}
