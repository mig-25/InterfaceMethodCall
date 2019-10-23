using System;

namespace CallInterfaceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Propulsions");
            //Instansiate new object and call its methods
            CallInterfaceFromAnotherClass call = new CallInterfaceFromAnotherClass();
            call.GetElectric();
            call.GetFusion();
        }
    }
}
