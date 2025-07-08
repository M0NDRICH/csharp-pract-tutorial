using SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithoutOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithOOP
{
    public class SimpleOperationWithOOP
    {
        public void Process()
        {
            Print(new Ninja("Shuriken") { Weapon = "Fireball" });
            Print(new Samurai("3 swords style") { Weapon = "Sword" });
        }
        public void Print(IMandirigma mandirigma)
        {
            mandirigma.Attack();
        }
    }
    #region -- Derive Class --
    public interface IMandirigma
    {
        string Name { get; }
        string Weapon { get; set; }
        public void Attack();
    }

    public abstract class Mandirigma : IMandirigma
    {
        private string _secretWeapon;
        public Mandirigma(string name, string secretWeapon)
        {
            Name = name;
            _secretWeapon = secretWeapon;
        }
        public string Name { get; private set; }
        public string Weapon { get; set; }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}: Attack By {Weapon} & {_secretWeapon}");

        }
        
    }

    public class Ninja : Mandirigma
    {
        public Ninja(string secret) : base("Ninja", secret) { }
    }
    public class Samurai : Mandirigma
    {
        public Samurai(string secret) : base("Samurai", secret) { }
        public override void Attack()
        {
            Console.WriteLine("OOP aproach na!");
            base.Attack();
        }
    }
    #endregion
}
