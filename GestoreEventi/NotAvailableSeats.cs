using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class NotAvailableSeats : Exception
    {
        public NotAvailableSeats() : base()
        {
        }
        public NotAvailableSeats(string message) : base(message)
        {
        }
    }
}