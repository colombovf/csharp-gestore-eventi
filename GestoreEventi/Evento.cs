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

        public Evento(string date, string title, int maxCapacity)
        {
            CheckDate(date);
            this.date = date;
            CheckTitle(title);
            this.title = title;
            CheckMaxCapacity(maxCapacity);
            this.maxCapacity = maxCapacity;
            this.reservedSeats = 0;
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
        public void setTitle(string title)
        {
           CheckTitle(title);
            this.title = title;
        }
        public void setDate(string date)
        {
            CheckDate(date);
            this.date = date;
        }

        public void setMaxCapacity(int newMaxCapacity)
        {
            CheckMaxCapacity(newMaxCapacity);
            this.maxCapacity = newMaxCapacity;
        }
  

        //METODI PRIVATI
        private void CheckTitle(string title)
        {
            while (title.Length <= 0)
            {
                Console.WriteLine("Inserire un titolo valido");
                title = Console.ReadLine();
            }
        }
        private void CheckDate(string date)
        {
           while (DateTime.Now > Convert.ToDateTime(date))
            {
                Console.WriteLine("Inserire una data corretta: gg/mm/aaaa");
                date = Console.ReadLine();
            }
        }

        private void CheckMaxCapacity(int NewMaxCapacity)
        {
            while (NewMaxCapacity <= 0)
            {
                Console.WriteLine("Inserire una capacità di posti positiva");
                NewMaxCapacity = int.Parse(Console.ReadLine());
            }
        }

        //METODI PUBBLICI

        public void ReserveSeats(int seats)
        {
            if(DateTime.Now > Convert.ToDateTime(date))
            {
                throw new ExpiredDate("La data è passata");
                return;
            }
            if (seats <= 0)
            {
                throw new NegativeSeatsNumber(
                "Il numero inserito è minore di 1");
                return;
            }

            if ((maxCapacity - reservedSeats) < seats)
            {
                throw new NotAvailableSeats(
                "Il numero inserito è maggiore di posti disponibili");
                return;
            }

            reservedSeats += seats;
        }
        public void CancelReservation(int seats)
        {

            if (DateTime.Now > Convert.ToDateTime(date))
            {
                throw new ExpiredDate("La data è passata");
                return;
            }
            if (seats <= 0)
            {
                throw new NegativeSeatsNumber(
                "Il numero inserito è minore di 1");
                return;
            }
            if(seats > reservedSeats)
            {
                throw new UnavailableCancelReservation("I posti da cancellare sono maggiori dei posti riservati");
                return;
            }

            reservedSeats -= seats;
        }
        public override string ToString()
        {
            string obj = $"{date} - {title}"; 
            return obj;
        }
    }
}
