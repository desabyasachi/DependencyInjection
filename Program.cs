using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Service sObj = new Service();

            //passing dependency
            DIClass d = new DIClass(sObj);
            d.PrintMethod();
            Console.ReadKey();
        }
    }
}
