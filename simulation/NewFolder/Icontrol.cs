using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    internal interface Icontrol // interface = class에서 외부 형태만 취한다(껍데기), 다중 상속 가능     , ctrl + k + c = 원하는 라인들 주석처리
    {
        public void Active();
        public void Deactive();
    }
}
