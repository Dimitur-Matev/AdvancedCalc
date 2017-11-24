using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Exeptions
{
    class NotCommandExeption : SystemException
    {
        public NotCommandExeption() { }

        public NotCommandExeption(string message) : base(message) { }
    }
}
