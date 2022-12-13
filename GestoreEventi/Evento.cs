using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //ATTRIBUTI
        private string title;
        private string date;
        private string maxCapacity;
        private string reservedSeats;

        //STATO
        //COSTRUTTORE
        public Evento() { }

        public Evento(string title, string date, string maxCapacity, string reservedSeats)
        {
            this.title = title;
            this.date = date;
            this.maxCapacity = maxCapacity;
            this.reservedSeats = reservedSeats;
        }

        //GETTER
        public string getTitle()
        {
            return title;
        }
        public string getDate()
        {
            return date;
        }
        public string getMaxCapacity()
        {
            return maxCapacity;
        }
        public string getReservedSeats()
        {
            return reservedSeats;
        }
 
        //SETTER
        public string setTitle()
        {
            if(title == "")
            {
                Console.WriteLine("Inserire un titolo valido");
            } return title;
        }
        public string setDate()
        {
            if (DateTime.Now > Convert.ToDateTime(date))
            {
                Console.WriteLine("Inserire una data valida");
            } return date;
        }
        //METODI
        public string ReserveSeats()
        {
            return;
        }
        public string CancelReservation()
        {
            return;
        }
        public override string ToString()
        {
            string obj =
            return obj;
        }
    }
}
