// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

public class ProgrammaEvento
{

    public string Titolo {get; set;}

    public List<Evento> Eventi { get; set; }

    public ProgrammaEvento(string titolo) 
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }




    //un metodo che aggiunge alla lista del programma eventi un Evento, passato come
    //parametro al metodo.
    public List<Evento> AggiungiEvento(Evento evento)
    {
        Eventi.Add(evento);
        return Eventi;
    }


    //● un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa
    //data.

    public List<Evento> RestituisciEventi(DateTime data)
    {
        List<Evento> eventiData = new List<Evento>();
        foreach (Evento evento in Eventi)
        {
            if (evento.Data == data)
            {
                eventiData.Add(evento);
            }
        }

        return eventiData;
    }
    //● un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o
    //ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.

    public static void StampaLista(List<Evento> eventi)
    {
        foreach (Evento evento in eventi)
        {
            Console.WriteLine(evento);
        }
    }


    //● un metodo che restituisce quanti eventi sono presenti nel programma eventi
    //attualmente.

    public int NumeroEventiPrevisti()
    {
        int numeroEventiPrevisti = 0;

        for (; numeroEventiPrevisti < Eventi.Count;)
        {
            numeroEventiPrevisti++;
        }

        return numeroEventiPrevisti;
    }


    //● un metodo che svuota la lista di eventi.
    public List<Evento> SvuotaLista(List<Evento> eventi)
    {
        eventi.Clear();
        return eventi;
    }



    //● un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli
    //eventi aggiunti alla lista.Come nell’esempio qui sotto:
    //Nome programma evento:
    //data1 - titolo1
    //data2 - titolo2
    //data3 - titolo3
    public string ListaEventi()
    {
        string lista = Titolo;


        foreach (Evento evento in Eventi)
        {
            lista = lista + "\n " + evento.ToString();  

        }

        return lista;

    }
   



   
}