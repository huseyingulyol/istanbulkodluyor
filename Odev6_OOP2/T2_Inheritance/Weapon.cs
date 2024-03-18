using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Inheritance
{
    public class Weapon
    {
        public void Equip()
        {
            Console.WriteLine("Equipped.");
        }
    }
    public class Sword : Weapon
    {
        public void Swing()
        {
            Console.WriteLine("Swinging...");
        }
    }
    public class Gun : Weapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing...");
        }
    }
}
