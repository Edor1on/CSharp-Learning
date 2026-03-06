using System;
using System.Xml.Linq;

namespace CSharplearning
{
    class RobotOOPKilljoy : RobotOOP
    {
        public int Damage {  get; set; }

        
        public RobotOOPKilljoy () { }

        // Виправляємо base: передаємо всі 5 штук
        public RobotOOPKilljoy(string name, short weight, int power, float version, byte[] coordinates, int damage) : base(name, weight, power, version, coordinates)
        {
            this.Damage = damage;
            base.printValues();
        }


        public void Lazer()
        {
            Console.WriteLine("Shooting from lazer");
        }
    }
}
