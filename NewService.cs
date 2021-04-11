using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class NewService : IService
    {
        public void Print()
        {
            Console.WriteLine("Hello from new service method");
        }
    }
}
