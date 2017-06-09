using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    class Squirrel : Animal, ICanbeinIKIT
    {
        public bool CAN()
        {
            return false;
        }
    }
}
