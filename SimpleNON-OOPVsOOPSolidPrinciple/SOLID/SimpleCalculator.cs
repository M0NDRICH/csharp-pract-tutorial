﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple.SOLID
{
    //O - Open for Extension, Closed for Modification
    public class SimpleCalculator
    {
        public void Calculate(Operation[] operations)
        {
            foreach(var operation in operations)
            {
                if(operation is Add)
                {
                    Console.WriteLine($"for Add class:; {operation.A + operation.B}");
                }
                else if (operation is Subtract)
                {
                    Console.WriteLine($"for Substract class: {operation.A - operation.B}");
                }
            }
        }
    }
    public abstract class Operation
    {
        public int A { get; set; }
        public int B { get; set; }
    }
    public class Add: Operation
    {
    }

    public class Subtract : Operation
    {
    }

    public class Multiply : Operation
    {
    }

    #region -- Open Close Principle --
    public interface IOperation
    {
        int A { get; set; }
        int B { get; set; }
        void Compute();
    }
    public abstract class Operationv2 : IOperation
    {
        public int A { get; set; }
        public int B { get; set; }
        public abstract void Compute(); // can virtual
    }
    public class AddV2 : Operationv2
    {
        public override void Compute()
        {
            Console.WriteLine($"for Add class: {A + B}");
        }
    }
    public class SubtractV2 : Operationv2
    {
        public override void Compute()
        {
            Console.WriteLine($"for Add class: {A - B}");
        }
    }
    public class SimpleCalculatorV2
    {
        public void Calculate(IOperation[] operations)
        {
            foreach(var operation in operations)
            {
                operation.Compute();
            }
        }
    }
    #endregion
}
