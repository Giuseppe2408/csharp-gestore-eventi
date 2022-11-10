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
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch (EventoException e)
{
    Console.WriteLine(e.Message);
}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (EventoException)
//{
//    Console.WriteLine("deve essere maggiore di 0");
//}


Console.WriteLine();

Console.WriteLine("dettagli evento:");

Console.WriteLine();

Console.WriteLine(nuovoEvento.ToString());

Console.WriteLine();

Console.WriteLine("quanti posti vuoi prenotare?");

int postidaPrenotare = Convert.ToInt32(Console.ReadLine());

int postiPrenotati = 0;
try
{
    postiPrenotati = nuovoEvento.PrenotaPosti(postidaPrenotare);
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("posti prenotati: " + postiPrenotati);
Console.WriteLine("posti disponibili: " + nuovoEvento.DisponibilitàPosti(postiPrenotati));


Console.WriteLine();
Console.WriteLine("vuoi disdire dei posti?");
string sceltaUtente = Console.ReadLine();

switch (sceltaUtente)
{
    case "si":
        Console.WriteLine("inserisci il numero dei posti da disdire");
        int postidaDisdire = Convert.ToInt32(Console.ReadLine());
        int postiDisdetti = 0;
        try
        {
            postiDisdetti = nuovoEvento.DisdiciPosti(postidaDisdire);
        } catch (Exception e)
        {
            Console.WriteLine();
            Console.WriteLine(e.Message);
            Console.WriteLine("re-inserisci posti da disdire");
            postidaDisdire = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine();
        Console.WriteLine("posti prenotati {0} posti", postiDisdetti);
        Console.WriteLine("posti disponibili: " + nuovoEvento.DisponibilitàPosti(postiDisdetti));
        break;

    case "no":
        Console.WriteLine();
        Console.WriteLine("ok vabene");
        Console.WriteLine();
        Console.WriteLine("posti prenotati: " + postiPrenotati);
        Console.WriteLine("posti disponibili: " + nuovoEvento.DisponibilitàPosti(postiPrenotati));
        break;

}

public class ProgrammaEvento : Evento
{
    List<Evento> ListaEventi { get; set; }
}