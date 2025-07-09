using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInheritanceAndGeneric
{
    public class SampleGeneric<T>
        where T: TagaCompute, new() //class, new()
    {
        public void Process(int num1, int num2)
        {
            T t = new T();
            t.Compute(num1, num2);
            Console.WriteLine($"Compute: {t.Result}");
        }
    }

    public class SampleMultipleType<Una, Pangalawa>
        where Una: TagaCompute, new()
        where Pangalawa: SampleGeneric<TagaMinus>, new()
    {
        public void Executena(int num1, int num2)
        {
            Una una = new Una();
            Pangalawa pangalawa = new Pangalawa();

            una.Compute(num1, num2);
            Console.WriteLine($"Una: {una.Result}");

            pangalawa.Process(num1, num2);
        }
    }
}
