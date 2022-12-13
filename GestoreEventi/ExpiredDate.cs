using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ExpiredDate : Exception
    {
        public ExpiredDate() : base()
        {
        }
        public ExpiredDate(string message) : base(message)
        {
        }
    }
}
