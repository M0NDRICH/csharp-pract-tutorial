using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithoutOOP
{
    public class SimpleOperationWithoutOOP
    {
        public void Process()
        {
            Print(new Ninja() { Weapon = "Fireball", SecretWeapon = "Shuriken" });
            Print(new Samurai() { Weapon = "Sword", SecretWeapon = "3 swords style" });
        }

        public void Print(Ninja ninja)
        {
            ninja.SecretWeapon = "Gun";
            ninja.Attack();
        }

        public void Print(Samurai samurai)
        {
            samurai.SecretWeapon = "Knife";
            samurai.Attack();
        }
    }

    #region -- Demo Class --
    public class Ninja
    {
        public string Name { get; } = "Ninja";
        public string SecretWeapon { get; set; }
        public string Weapon { get; set; }
        public void Attack()
        {
            Console.WriteLine($"{Name}: Attack By {Weapon} & {SecretWeapon}");
        }
    }

    public class Samurai
    {
        public string Name { get; } = "Samurai";
        public string SecretWeapon { get; set; }
        public string Weapon { get; set; }
        public void Attack()
        {
            Console.WriteLine($"{Name}: Attack By {Weapon} & {SecretWeapon}");
        }
    }
    #endregion
}
