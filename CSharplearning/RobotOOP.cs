using System;
using System.Xml.Linq;

namespace CSharplearning
{
    class RobotOOP
    {
        private string name;
        private short weight;
        private int power;
        private float version;
        private byte[] coordinates;


        // constructor

        public RobotOOP() { count++; }

        public RobotOOP(string _name) {
            this.name = _name;
            Console.WriteLine("You are borned!!!");
            count++;
        }

        public RobotOOP (string _name, short _weight, int _power, float _version, byte[] _coordinates)
        {
            this.SetValues(_name, _weight, _power, _version, _coordinates);
            this.printValues();
            count++;
        }

        public static int count = 0;

        public static int value = 0;




        public static void PrintSOmeText()
        {
            Console.WriteLine("Hello OOP");
        }


        public static void PrintCount()
        {
            Console.WriteLine("Count: " + count);
        }


        // methods
        public void SetValues(string name, short weight, int power, float version, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.power = power;
            this.version = version;
            this.coordinates = coordinates;
        }

        public void printValues()
        {
            Console.WriteLine(this.name + ": weight: " + this.weight + ", power: " + this.power + ", version " + this.version + ", coordinates: ");
            foreach(byte el in this.coordinates){
                Console.Write(el + " - ");
            }
        Console.WriteLine("");

        }


        // Аксесори get set

        public int Width { private get; set; }

        public short Weight
        {
            get
            {
                Console.WriteLine("Result of waight: ");
                return this.weight;
            }
            set
            {
                if (value < 1)
                {
                    weight = 0;
                }
                this.Weight = value;
            }
        }
    }
}
