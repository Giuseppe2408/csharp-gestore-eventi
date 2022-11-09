// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

Console.WriteLine("Ciao inserisci un nuovo evento");

Console.WriteLine();

Console.WriteLine("inserisci il titolo dell'evento");

string titoloEvento = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("inserisci la data dell'evento nel seguente formato : (dd/MM/yyyy)");

DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("inserisci la capienza massima dell'evento");

int capienzaEvento = Convert.ToInt32(Console.ReadLine());

Evento nuovoEvento = new Evento();

try
{
     nuovoEvento = new Evento(titoloEvento, dataEvento, capienzaEvento);
}
catch (ArgumentNullException)
{
    Console.WriteLine("questo non può essere null");
}
catch (EventoException)
{
    Console.WriteLine("deve essere maggiore di 0");
}


Console.WriteLine();

Console.WriteLine("dettagli evento:");

Console.WriteLine();

//Console.WriteLine(nuovoEvento.ToString());
