using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton_design_pattern
{
    internal class Singelton
    {
        private static Singelton _instatnt;
        private Singelton()
        {
            
        }
        public static Singelton getInstatnt()
        {
            if (_instatnt == null)
            {
                _instatnt = new Singelton();
            }
            return _instatnt;
        }
    }
}
