// See https://aka.ms/new-console-template for more information

using GestoreEventi;

Console.Write("Data:");
string data = Console.ReadLine();
Console.Write("Titolo:");
string title = Console.ReadLine();
Console.Write("Posti massimi:");
int maxP = int.Parse(Console.ReadLine());


Evento e = new Evento(data , title , maxP);

Console.WriteLine(e);
/*

Console.WriteLine("Posti da riservare ?");
e.ReserveSeats(int.Parse(Console.ReadLine()));

Console.WriteLine("Posti da cancellare ?");
e.CancelReservation(int.Parse(Console.ReadLine()));

Console.WriteLine(e);
*/


Console.WriteLine("Vuoi Prenotarere dei posti a sedere? (si/no)");
string risposta = Console.ReadLine();
while (risposta == "si")
{
    Console.Write("Quanti posti a sedere vuoi prenotare?");
    int seats = int.Parse(Console.ReadLine());
    e.ReserveSeats(seats);
    e.getReservedSeats();
    Console.WriteLine("Posti prenotati: " + e.getReservedSeats());
    Console.WriteLine("Posti liberi: " + (e.getMaxCapacity() - e.getReservedSeats()));
    Console.WriteLine("Vuoi Prenotarere altri posti a sedere? (si/no)");
    risposta = Console.ReadLine();

}



Console.WriteLine("Vuoi disdire unaa prenotazione? (si/no)");
risposta = Console.ReadLine();
while (risposta == "si")
{
    Console.Write("Quanti posti prenotati vuoi disdire?");
    int seats = int.Parse(Console.ReadLine());
    e.CancelReservation(seats);
    e.getReservedSeats();
    Console.WriteLine("Posti prenotati: " + e.getReservedSeats());
    Console.WriteLine("Posti liberi: " + (e.getMaxCapacity() - e.getReservedSeats()));
    Console.WriteLine("Vuoi disdire altri posti prenotati?? (si/no)");
    risposta = Console.ReadLine();
}


