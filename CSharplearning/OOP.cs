using System;

namespace CSharplearning
{
    class OOP
    {
        private string name;
        private short weight;
        private int power;
        private float version;
        private byte[] coordinates;


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
