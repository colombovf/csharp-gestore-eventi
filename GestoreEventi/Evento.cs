using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //ATTRIBUTI
        private string title;
        private string date;
        private int maxCapacity;
        private int reservedSeats;

        //STATO
        //COSTRUTTORE
        public Evento() { }

        public Evento(string title, string date, int maxCapacity, int reservedSeats)
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
        public int getMaxCapacity()
        {
            return maxCapacity;
        }
        public int getReservedSeats()
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

        private int setMaxCapacity()
        {
            if (maxCapacity >= 0)
            {
                Console.WriteLine("La capacità massima dei posti deve essere maggiore di zero");
            } return maxCapacity;
        }

        //METODI
        public int ReserveSeats(int seats)
        {
            int maxCapacityReserved = maxCapacity - reservedSeats;
            if (seats > maxCapacityReserved)
            {
                Console.WriteLine("Superata la massima capienza di posti, inserire un numero valido di posti da riservare");
            }
            else if (seats < 0)
            {
                Console.WriteLine("Inserire un numero di posti maggiore di zero");
            }return reservedSeats += seats;
        }
        public int CancelReservation(int seats)
        {
            return reservedSeats -= seats;
        }
        public override string ToString()
        {
            string obj =
            return obj;
        }
    }
}
