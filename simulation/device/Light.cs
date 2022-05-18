using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    internal class Light : Icontrol
    {
        private bool isOn;

        public Light(bool OnOFF = false)
        {
            this.isOn = OnOFF;
        }
        // On, Off 함수 제작해도 상관없음
        public void On()
        {
            Console.WriteLine("Light On");
        }
        public void Off()
        {
            Console.WriteLine("Light Off");
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
