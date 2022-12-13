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

        public int ReserveSeats(int seats)
        {
            int maxCapacityReserved = maxCapacity - reservedSeats;
            if (seats > maxCapacityReserved)
            {
                Console.WriteLine("Superata la massima capienza di posti, inserire un numero valido di posti da riservare");
                //ECCEZIONE
            }
            else if (seats < 0)
            {
                Console.WriteLine("Inserire un numero di posti maggiore di zero");
                //ECCEZIONE
            }return reservedSeats += seats;
            //Aggiungere un'ECCEZIONE se l'evento è già passato
        }
        public int CancelReservation(int seats)
        {
            //Aggiungere un'ECCEZIONE se l'evento è già passato
            if(seats > reservedSeats)
            {
                Console.WriteLine("Selezionare un numero corretto di posti riservati da disdire");
                //ECCEZIONE
            }
            return reservedSeats -= seats;
        }
        public override string ToString()
        {
            string obj = $"{date} - {title}"; 
            return obj;
        }
    }
}
