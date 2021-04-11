using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class DIClass
    {
        private readonly IService _iService;
        public DIClass(IService iService)
        {
            this._iService = iService;
        }

        public void PrintMethod()
        {
            _iService.Print();
        }
    }
}
