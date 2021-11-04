using System;

namespace AbstractClassOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------------------------------------------------------------------- ");
            Console.WriteLine("|Opdracht 5: Abstract Class                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------- ");
            Equipment g;
            g = new Weapon();
            g.PickitUp();
            g.equip();
            Console.WriteLine("-------------------------------------------------------------------------");
            Equipment a;
            a = new Armor();
            a.PickitUp();
            a.equip();
            Console.WriteLine("-------------------------------------------------------------------------");
            Pickups m;
            m = new Money();
            m.PickitUp();
            Console.WriteLine("-------------------------------------------------------------------------");
            Pickups hp;
            hp = new HealingPotion();
            hp.PickitUp();
            Console.WriteLine("-------------------------------------------------------------------------");
            Pickups mp;
            mp = new ManaPotion();
            mp.PickitUp();
            Console.WriteLine("-------------------------------------------------------------------------");
        }
        
    }
    abstract class Equipment : Pickups
    {
        public abstract void equip();
    }

    class Armor : Equipment
    {
        public override void equip()
        {
            Console.WriteLine("Equip Armor from Equipment");
        }
        public override void PickitUp()
        {
            Console.WriteLine("Pick the Armor up");
        }
    }

    class Weapon : Equipment
    {
        public override void equip()
        {
            Console.WriteLine("Equip Weapon from Equipment");
        }
        public override void PickitUp()
        {
            Console.WriteLine("Pick the weapon up");
        }
    }

    abstract class Pickups 
    {
        public abstract void PickitUp();
    }

    class Money : Pickups
    {
        public override void PickitUp()
        {
            Console.WriteLine("Pick up the Money");
        }
       
    }

    class HealingPotion : Pickups
    {
        public override void PickitUp()
        {
            Console.WriteLine("Pick up the Healing Potion");
        }
       
    }

    class ManaPotion : Pickups
    {
        public override void PickitUp()
        {
            Console.WriteLine("Pick up the Mana Potion");
        }
       
    }

   
}
