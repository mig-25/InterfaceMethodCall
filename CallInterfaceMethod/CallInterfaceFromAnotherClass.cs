using System;
using System.Collections.Generic;
using System.Text;

namespace CallInterfaceMethod
{
    class CallInterfaceFromAnotherClass
    {
        //Methods to use interface from original class
        public void GetElectric()
        {
            IamElectric electric = new Propulsion();
            electric.IsElectric();
        }

        public void GetFusion()
        {
            IamFusion fusion = new Propulsion();
            fusion.IsFusion();
        }
    }
}
