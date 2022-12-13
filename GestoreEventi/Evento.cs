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
            CheckTitle(title);
            CheckMaxCapacity(maxCapacity);
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
        
        }
        public void setDate(string date)
        {
            CheckDate(date);
        }

        public void setMaxCapacity(int newMaxCapacity)
        {
            CheckMaxCapacity(newMaxCapacity);
        }
  

        //METODI PRIVATI
        private void CheckTitle(string title)
        {
            if (title.Length <= 0)
            {
                throw new Exception("Titolo vuoto");
            }
            this.title = title;

            /*  Soluzione alternativa senza Exception
            while (title.Length <= 0)
            {
                Console.WriteLine("Inserire un titolo valido");
                title = Console.ReadLine();
            }
            this.title = title;
            */
        }
        private void CheckDate(string date)
        {
            if (DateTime.Now > DateTime.Parse(date))
            {
                throw new ExpiredDate("Data passata");
            }

            this.date = date ;

            /*  Soluzione alternativa senza Exception
            while (DateTime.Now > Convert.ToDateTime(date))
            {                
                throw new ExpiredDate("La data è passata");
                Console.WriteLine("Inserire una data corretta: gg/mm/aaaa");
                date = Console.ReadLine();
            }*/
        }

        private void CheckMaxCapacity(int NewMaxCapacity)
        {
            if (NewMaxCapacity <= 0)
            {
                throw new Exception("Numero minore di 1");
            }
            this.maxCapacity = NewMaxCapacity;


            /*  Soluzione alternativa senza Exception

            while (NewMaxCapacity <= 0)
            {
                Console.WriteLine("Inserire una capacità di posti positiva");
                NewMaxCapacity = int.Parse(Console.ReadLine());
            }
            this.maxCapacity = NewMaxCapacity;
            */
        }

        //METODI PUBBLICI

        public void ReserveSeats(int seats)
        {
            if (DateTime.Now > DateTime.Parse(date))
            {
                throw new   ExpiredDate("La data è passata");
            }
            if (seats <= 0)
            {
                throw new NegativeSeatsNumber(
                "Il numero inserito è minore di 1");
            }

            if ((maxCapacity - reservedSeats) < seats)
            {
                throw new Exception(
                "Il numero inserito è maggiore di posti disponibili");
            }

            reservedSeats += seats;
        }
        public void CancelReservation(int seats)
        {

            if (DateTime.Now > DateTime.Parse(date))
            {
                throw new ExpiredDate("La data è passata");
            }
            if (seats <= 0)
            {
                throw new NegativeSeatsNumber(
                "Il numero inserito è minore di 1");
            }
            if(seats > reservedSeats)
            {
                throw new UnavailableCancelReservation("I posti da cancellare sono maggiori dei posti riservati");
            }

            reservedSeats -= seats;
        }
        public override string ToString()
        {
            string obj = $"{date} - {title} - {maxCapacity} - {reservedSeats}"; 
            return obj;
        }
    }
}
