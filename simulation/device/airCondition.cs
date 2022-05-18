using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    internal class airCondition : Icontrol
    {
        private bool isOn;

        public airCondition(bool OnOFF = false)
        {
            this.isOn = OnOFF;
        }

        public void Active() 
        {
            Console.WriteLine("AirCon On");
        }
        public void Deactive()
        {
            Console.WriteLine("AirCon Off");
        }
    }
}
