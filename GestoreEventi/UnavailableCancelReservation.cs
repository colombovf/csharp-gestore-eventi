using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class UnavailableCancelReservation : Exception
    {
        public UnavailableCancelReservation() : base()
        {
        }
        public UnavailableCancelReservation(string message) : base(message)
        {
        }
    }
}
