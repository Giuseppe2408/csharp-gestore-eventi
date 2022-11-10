// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

//Console.WriteLine("Ciao inserisci un nuovo evento");

//Console.WriteLine();

//Console.WriteLine("inserisci il titolo dell'evento");

//string titoloEvento = Console.ReadLine();

//Console.WriteLine();

//Console.WriteLine("inserisci la data dell'evento nel seguente formato : (dd/MM/yyyy)");

//DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());

//Console.WriteLine();

//Console.WriteLine("inserisci la capienza massima dell'evento");

//int capienzaEvento = Convert.ToInt32(Console.ReadLine());

//Evento nuovoEvento = new Evento();

//try
//{
//    nuovoEvento = new Evento(titoloEvento, dataEvento, capienzaEvento);
//}
//catch (ArgumentNullException e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (EventoException e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}



//Console.WriteLine();

//Console.WriteLine("dettagli evento:");

//Console.WriteLine();

//Console.WriteLine(nuovoEvento.ToString());

//Console.WriteLine();

//Console.WriteLine("quanti posti vuoi prenotare?");

//int postidaPrenotare = Convert.ToInt32(Console.ReadLine());

//int postiPrenotati = 0;
//try
//{
//    postiPrenotati = nuovoEvento.PrenotaPosti(postidaPrenotare);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.WriteLine("posti prenotati: " + postiPrenotati);
//Console.WriteLine("posti disponibili: " + nuovoEvento.DisponibilitàPosti(postiPrenotati));


//Console.WriteLine();
//Console.WriteLine("vuoi disdire dei posti?");
//string sceltaUtente = Console.ReadLine();

//switch (sceltaUtente)
//{
//    case "si":
//        Console.WriteLine("inserisci il numero dei posti da disdire");
//        int postidaDisdire = Convert.ToInt32(Console.ReadLine());
//        int postiDisdetti = 0;
//        try
//        {
//            postiDisdetti = nuovoEvento.DisdiciPosti(postidaDisdire);
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine();
//            Console.WriteLine(e.Message);
//            Console.WriteLine("re-inserisci posti da disdire");
//            postidaDisdire = Convert.ToInt32(Console.ReadLine());

//        }
//        Console.WriteLine();
//        Console.WriteLine("posti prenotati {0} posti", postiDisdetti);
//        Console.WriteLine("posti disponibili: " + nuovoEvento.DisponibilitàPosti(postiDisdetti));
//        break;

//    case "no":
//        Console.WriteLine();
//        Console.WriteLine("ok vabene");
//        Console.WriteLine();
//        Console.WriteLine("posti prenotati: " + postiPrenotati);
//        Console.WriteLine("posti disponibili: " + nuovoEvento.DisponibilitàPosti(postiPrenotati));
//        break;

//}


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
                //Console.WriteLine(programmaEvento.Eventi[i].Titolo);
                ////programmaEvento.StampaLista();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EventoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }      
           
        }
        Console.WriteLine();
        Console.WriteLine("il numero di eventi inseriti è: {0}", numeroEventiUtente);

        Console.WriteLine("ecco la lista dei tuoi eventi:");

        Console.WriteLine(programmaEvento.ListaEventi());

        break;
}

//Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno
//tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente.