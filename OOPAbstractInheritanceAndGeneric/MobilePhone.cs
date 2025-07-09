using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInheritanceAndGeneric
{
    public class MobilePhone
    {
        //Field
        private string _microChip;
        
        //Property
        public string Shape {  get; set; }
        public string Color { get; set; }

        public void PowerOn()
        {
            ConnectMainboardToPowerSupply();
            OpenWifiChip();
        }
        
        private void ConnectMainboardToPowerSupply() { }
        private void OpenWifiChip() { }
    }
}
