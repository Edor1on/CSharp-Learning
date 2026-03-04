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
            SetValues(_name, _weight, _power, _version, _coordinates);
            printValues();
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
        public void SetValues(string _name, short _weight, int _power, float _version, byte[] _coordinates)
        {
            name = _name;
            weight = _weight;
            power = _power;
            version = _version;
            coordinates = _coordinates;
        }

        public void printValues()
        {
            Console.WriteLine(name + ": weight: " + weight + ", power: " + power + ", version " + version + ", coordinates: ");
            foreach(byte el in coordinates){
                Console.Write(el + " - ");
            }
        Console.WriteLine("");


        }
    }
}
