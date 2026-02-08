using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharplearning
{
    internal class Practice_1
    {
        public Practice_1()
        {
            byte[] nums1 = { 5, 7, 8 };
            //int summa = 0;

            //foreach(int el in nums1)
            //{
            //    summa += el;
            //}
            //Console.WriteLine("Resullt: " + summa);
            Sumik(nums1);
            int res1 = Sumik(nums1);


            byte[] nums2 = { 5, 9, 8 };
            //int summa1 = 0;

            //foreach (int el in nums2)
            //{
            //    summa1 += el;
            //}
            //Console.WriteLine("Resullt: " + summa1);  // Не зручно
            Sumik(nums2);
            int res2 = Sumik(nums2);


            if (res1 > res2)
            {
                Console.WriteLine("Max is: " + res1);
            }
            else
            {
                Console.WriteLine("Max is: " + res2);
            }
        }

        public static int Sumik(byte[] digits)
        {
            int summa2 = 0;
            foreach(int el in digits)
            {
                summa2 += el;
            }
            //Console.WriteLine("Result: " + summa2);
            return summa2;
        }
    }
}
