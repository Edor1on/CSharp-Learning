using System;

namespace CSharplearning
{
    class BotOOP : RobotOOP
    {
        public BotOOP () {}

        public BotOOP (string name, short weight, int power, float version, byte[] coordinates) : base(name, weight, power, version, coordinates)
        {

        }

        public override void Moving(int speed)
        {
            Console.WriteLine("Moving BOT: " + speed);

        }
    }
}
