using System;

namespace CallInterfaceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Propulsions");
            
            IamElectric electric = new Propulsion();
            electric.IsElectric();

            IamFusion fusion = new Propulsion();
            fusion.IsFusion();
        }
    }
}
