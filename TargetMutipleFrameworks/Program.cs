using System;

namespace TargetMutipleFrameworks
{
    class Program
    {
        static void Main(string[] args)
        {
            #if NET40
            Console.WriteLine("Target framework: .NET Framework 4.0");
            
            #elif NET45
            Console.WriteLine("Target framework: .NET Framework 4.5");
            
            #else
            Console.WriteLine("Target framework: .NET Core 2.0");
            
            #endif
            Console.ReadKey();
        }
    }    
}
