using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class NegativeSeatsNumber : Exception
    {
        public NegativeSeatsNumber() : base()
        {
        }
        public NegativeSeatsNumber(string message) : base(message)
        {
        }
    }
}
