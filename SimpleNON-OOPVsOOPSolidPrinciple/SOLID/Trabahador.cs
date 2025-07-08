using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple.SOLID
{
    //internal class Trabahador{}
    public interface ITrabahador
    {
        string Name { get; set; }
        void GetSalary();
        void MaghugasPlato();
        void MaglinisNangBahay();
        void Maglaba();
        void MagPlantsa();
    }

    public class TagaLaba : ITrabahador
    {
        public string Name { get; set; }
        public void GetSalary()
        {
            Console.WriteLine("get Salary");
        }
        public void MaghugasPlato()
        {
            Console.WriteLine("Plato");
        }
        public void Maglaba()
        {
            Console.WriteLine("Laba");
        }
        public void MaglinisNangBahay()
        {
            Console.WriteLine("Linis");
        }
        public void MagPlantsa()
        {
            Console.WriteLine("Plantsa");
        }
    }

    #region -- Interface Segration --

    public interface ITrabahador2
    {
        string Name { get; set; }
        void GetSalary();
    }
    public interface ITagaHugas : ITrabahador2
    {
        void MaghugasPlato();
    }
    public interface ITagaLinis : ITrabahador2
    {
        void MaglinisNangBahay();
    }
    public interface ITagaLaba : ITrabahador2
    {
        void Maglaba();
    }
    public interface ITagaPlantsa : ITrabahador2
    {
        void MagPlantsa();
    }
    public interface TagalabaNaPlantsadoraPa : ITagaLaba, ITagaPlantsa
    { }
    public abstract class Trabahador : ITrabahador2
    {
        public string Name { get; set; }
        public void GetSalary()
        {
            Console.WriteLine("get Salary");
        }
    }
    public  class TagaLabav2 : Trabahador, ITagaLaba
    {
        public void Maglaba()
        {
            Console.WriteLine("Laba");
        }
    }
    #endregion
}
