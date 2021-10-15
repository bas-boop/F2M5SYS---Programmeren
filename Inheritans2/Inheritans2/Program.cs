using System;

namespace Inheritans2
{
    abstract class Equipment
    {
        public abstract void Equip();
    }
    class Weapon : Equipment
    {
        string Sword = ("Sword");
        public override void Equip()
        {
            Console.WriteLine(Sword);
        }
    }
    class Armor : Equipment
    {
        string Iron = ("Iron armor");
        public override void Equip()
        {
            Console.WriteLine(Iron);
        }
    }
}
