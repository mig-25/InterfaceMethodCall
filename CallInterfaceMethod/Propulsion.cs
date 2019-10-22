using System;
using System.Collections.Generic;
using System.Text;

namespace CallInterfaceMethod
{
    class Propulsion : IamElectric, IamFusion
    {
        void IamElectric.IsElectric()
        {
            Console.WriteLine("My propulsion is electric");
        }

        void IamFusion.IsFusion()
        {
            Console.WriteLine("My propulsion is fusion");
        }
    }
}
