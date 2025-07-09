using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInheritanceAndGeneric
{
    public abstract class TagaCompute
    {
        private string _securedData;
        protected int _result;

        public int Result
        {
            get { 
                return _result;
            }
        }

        public virtual void Compute (int num1, int num2)
        {
            _result = num1 + num2;
        }
    }
}
