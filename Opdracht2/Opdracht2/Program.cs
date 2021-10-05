using System;

namespace Opdracht2
{
    class Program
    {
        public static void Main()
        {
            Enemy enemy = new Enemy();

            Console.WriteLine("Help me, there is a moster here!");
            Console.WriteLine("Aight, im gonna slap him 10 times.");

            for (int i = enemy.Gaming(); i > -1; i--)
            {
                Console.WriteLine("*SLAP*");
                Console.WriteLine("enemy hp = {0}", i);
            }

            Console.WriteLine("it is dead.");
        }
    }
}