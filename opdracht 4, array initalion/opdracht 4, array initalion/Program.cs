using System;

namespace opdracht_4__array_initalion
{
    class Program
    {
        static void Main()
        {
            Room naam = new Room();
            Console.WriteLine(naam);

        }
    }
    class Room
    {
        public void Tada()
        {
            int[][] iets2 = new int[10][];
            for (int b = 0; b < iets2.Length; b++)
            {
                iets2[b] = new int[2];
                for (int f = 0; f < iets2[b].Length; f++)
                {
                    iets2[b][f] = 0;
                }
            }
        }
    }
    class Tile
    {
        static void nogwat()
        {

        }
    }
}
