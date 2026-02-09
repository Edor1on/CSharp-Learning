using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharplearning
{
    internal class functionsik
    {
        public functionsik() 
        {
            Print("Sone");
            Print("Some");
            Print("CAM");

            string words = "Annabell";
            Print(words);

            Summa(5, 8);

            int IOP = QWER(15, 15);
            
        }

        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

        public static void Summa(int a, int b)
        {
            int res = a + b;
            Print(res.ToString());
        }

        public static int QWER(int c, int d)
        {
            int res2 = c + d;
            return res2;
        }
    }
}
