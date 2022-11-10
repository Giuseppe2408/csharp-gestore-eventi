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
catch (DataException e)
{
    Console.WriteLine(e.Message);
}
catch (EventoException e)
{
    Console.WriteLine(e.Message);
}



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
}
catch (Exception e)
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
        }
        catch (Exception e)
        {
            Console.WriteLine();
            Console.WriteLine(e.Message);

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


Console.Clear();
Console.WriteLine("vuoi creare un programma di eventi?");
string sceltaCreazioneProgramma = Console.ReadLine();   

switch (sceltaCreazioneProgramma)
{
    case "si":
        Console.WriteLine();
        Console.WriteLine("titolo del tuo programma eventi");
        Console.WriteLine();
        string titolo = Console.ReadLine();

        ProgrammaEvento programmaEvento = new ProgrammaEvento(titolo);

        Console.WriteLine("quanti eventi vuoi aggiungere?");
        int numeroEventiUtente = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numeroEventiUtente; i++)
        {
            Console.WriteLine("inserisci evento");
            Console.WriteLine();
            Console.WriteLine("inserisci titolo evento");
            string titoloProgrammaEvento = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("inserisci data evento");
            DateTime dataProgrammaEvento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("inserisci capienza evento");
            int capienzaProgrammaEvento = Convert.ToInt32(Console.ReadLine());
            try
            {
                Evento evento = new Evento(titoloProgrammaEvento, dataProgrammaEvento, capienzaProgrammaEvento);
                programmaEvento.AggiungiEvento(evento);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EventoException e)
            {
                Console.WriteLine(e.Message);
            }



        }
        Console.WriteLine();
        //Stampate il numero di eventi presenti nel vostro programma eventi
        Console.WriteLine("il numero di eventi presenti è: {0}", programmaEvento.NumeroEventiPrevisti());

        //2.Stampate la lista di eventi inseriti nel vostro programma usando il metodo già fatto
        Console.WriteLine();
        Console.WriteLine("ecco la lista dei tuoi eventi:");
        Console.WriteLine();

        Console.WriteLine(programmaEvento.ListaEventi());







        //3.Chiedere all’utente una data e stampate tutti gli eventi in quella data. Usate il metodo
        //che vi restituisce una lista di eventi in una data dichiarata e create un metodo statico
        //che si occupa di stampare una lista di eventi che gli arriva. Passate dunque la lista di
        //eventi in data al metodo statico, per poterla stampare. 
        Console.WriteLine();
        Console.WriteLine("inserisci una data per vedere gli eventi disponibili");
        DateTime dataEventi = Convert.ToDateTime(Console.ReadLine());
        List<Evento> listaEventiData = programmaEvento.RestituisciEventi(dataEventi);
        ProgrammaEvento.StampaLista(listaEventiData);

        //4.Eliminate tutti gli eventi dal vostro programma. 
        programmaEvento.SvuotaLista(programmaEvento.Eventi);

        break;
    case "no":
        Console.WriteLine("ok vabene");
        break;
}

//Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno
//tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente.