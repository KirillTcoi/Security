using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    class Dog : Animal , ICanbeinIKIT 
    {
        public bool CAN()
        {
            return true;
        }
    }
}
