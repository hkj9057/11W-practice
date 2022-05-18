using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    class tvCtrl : Icontrol
    {
        private bool isOn;
        //public tvCtrl()
        //{
          //  this.isOn = Off;
        //}
        public void On()
        {
            Console.WriteLine("TV On");
        }
        public void Off()
        {
            Console.WriteLine("TV Off");
        }
        public void Active()
        {
            this.On();
        }
        public void Deactive()
        {
            this.Off();
        }
    }
}
