// See https://aka.ms/new-console-template for more information



//MILESTONE 1

using System.Linq.Expressions;

public class Evento
{
    string _titolo;
    int _capienzaEvento;
    int _numeroposti;
    int _postiDisdetti;
    DateTime _dataevento;
    //ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo
    //non sia vuoto e che la capienza massima di posti sia un numero positivo.In caso contrario
    //sollevare opportune eccezioni.

    public string Titolo
    {
        get
        {
            return _titolo;
        }
        set
        {
            //if (Titolo == null || Titolo == "")
            //{
            //    throw new ArgumentNullException("inserisci un formato valido");
                
            //}
            //else
            //{
                //throw new ArgumentNullException("inserisci un formato valido");
                _titolo = value;
            //}
            
        }
    }

    public DateTime Data
    {
        get
        {
            return _dataevento;
        }
        set
        {
            //if (Data < DateTime.Today)
            //{

            //    throw new Exception("non puoi inserire una data passata");
            //}
            //else
            //{

                _dataevento = value;
            //}
        }
    }



    public int CapienzaEvento {
        get
        {
            return _capienzaEvento;
        }

        private set 
        {
            //if (CapienzaEvento < 0)
            //{
            //    throw new EventoException("iserisci un numero positivo");
            //} 
            //else
            //{
                _capienzaEvento = value;
            //}
            
            
            
        } 
    }
    public int NumeroPostiPrenotati { get; private set; }

    public Evento()
    {

    }

    public Evento(string titolo, DateTime dataevento, int capienzaEvento)
    {
        Titolo = titolo;
        Data = dataevento;
        CapienzaEvento = capienzaEvento;
        NumeroPostiPrenotati = 0;
    }

    public int PrenotaPosti(int postiPrenotati) 
    {
        //PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.Se
        if (Data < DateTime.Today || postiPrenotati > CapienzaEvento)
            throw new Exception("errore");
        

        return _numeroposti = NumeroPostiPrenotati + postiPrenotati;
        
        
    }

    public int DisponibilitàPosti(int postidisponibili)
    {
        int postiPrenotati = PrenotaPosti(postidisponibili);
        int postiDisponibili = 0;
        if (_postiDisdetti == 0) 
            return postiDisponibili = CapienzaEvento - postiPrenotati;

        return postiDisponibili + _postiDisdetti;
    }

 

    public int DisdiciPosti(int postiDisdetti)
    {
        //permette di disdire i posti prenotati
        if (Data < DateTime.Today || postiDisdetti > _numeroposti)
            throw new Exception("errore");
        
        return _numeroposti - postiDisdetti;
       
    }

    public override string ToString()
    {
        //restituisce la data e il titolo dell'evento
        return Data.ToString("dd/MM/yyyy") + " " + Titolo;
    }


}
