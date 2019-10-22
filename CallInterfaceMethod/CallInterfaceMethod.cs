using System;
using System.Collections.Generic;
using System.Text;

namespace CallInterfaceMethod
{
    class CallInterfaceMethod
    {
        Propulsion propulsion;

        IamElectric electric = new Propulsion();
        //electric.IsElectric();
        //(electric as Propulsion).IsElectric();
    }
}
