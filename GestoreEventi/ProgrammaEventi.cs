using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        //ATTRIBUTI
        private string title;
        List<Evento> eventi;
        //STATO
        //COSTRUTTORE
        public ProgrammaEventi() { }

        public ProgrammaEventi(string title)
        {
            this.title = title;
            eventi = new List<Evento>();
        }
        //GETTER
        //SETTER
        //METODI
        public void NewEvent(string data, string title, int maxCapacity)
        {
            eventi.Add(new Evento(data, title, maxCapacity));
        }

        public List<Evento> EventperDate(string date)
        {
            List<Evento> cercaEventi = new List<Evento>();
            foreach(Evento evento in eventi)
            {
                if (evento.getDate() ==date) 
                {
                cercaEventi.Add(evento);
                }
            }

            return cercaEventi;
        }

        public static string ListEventToString(List<Evento> list) 
        {
            string x = "";

            foreach(Evento e in list)
            {
                x =  x + e.ToString()  + " ";
            }
            return x;
        }

        public int CountEvent()
        {
            int count = 0;

            foreach (Evento e in eventi)
            {
                count++;
            }
            return count;
        }

        public void ClearList()
        {
            eventi.Clear();
        }


        public override string ToString()
        {
            string s = "Titolo Programma Eventi: " + this.title;
            foreach (Evento e in eventi)
            {
                s = s + "\n" + e.ToString();
            }
            return s;


        }



    }
}
