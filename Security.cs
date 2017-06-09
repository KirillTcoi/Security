using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public static class Security
    {
        public static void Skipper(ArrayList List, ICanbeinIKIT who)
        {
            if (who.CAN()) List.Add(who);
        }
    }
    public interface ICanbeinIKIT
    {
        bool CAN();
    }
}
