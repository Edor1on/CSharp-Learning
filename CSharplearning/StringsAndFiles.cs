using System;
using System.IO;
using System.Security.Cryptography;

namespace CSharplearning
{
    internal class StringsAndFiles
    {
        public StringsAndFiles() 
        {
            string word = "Hello";
            word += "!!!";

            char[] words = { 'H', 'I' };

            Console.WriteLine(String.Compare(word, "LLo"));  // 0 - рівні обидваб 1 - LLo більше за зміну стрінга -1 - LLo менше за ту зміну



            string people = "  Alex,Yura,Gay  ";
            string[] names = people.Split(','); // розділяє
            //foreach(string el in names)
            //{
            //    Console.WriteLine(el);
            //}

            people = String.Join(" | ", names); // Об'єднює
            Console.WriteLine(people.Trim()); // Trim - забирає передні 2 пробіла та задні
            Console.WriteLine(people.ToUpper());
            Console.WriteLine(people.Substring(10)); // Видаляє перші 10 символів
            Console.WriteLine(people.Substring(0, people.Length - 6)); //Видаляє останні 6 симоволів, тобто спочатку від першого до останнього рахує, а потім останні 6 віднімає


            // work with file
            // create and write in file
            Console.Write("Enter text to file: ");
            string text = Console.ReadLine();
            using (FileStream stram = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                stram.Write(array);
            }


            Console.WriteLine("Read in file");
            using(FileStream stream = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[stream.Length];
                stream.Read(array);

                string TextFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Text from file: " + TextFromFile);
            }
        }
    }
}
