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
    int _postiDisponibili;
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
            if (value == null || value == "")
            {
                throw new ArgumentNullException("inserisci un formato valido");

            }
            else
            {
                _titolo = value;
            }

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
            if (value < DateTime.Today)
            {

                throw new DataException("non puoi inserire una data passata");
            }
            else
            {

                _dataevento = value;
            }
        }
    }



    public int CapienzaEvento {
        get
        {
            return _capienzaEvento;
        }

        private set 
        {
            if (value < 0)
            {
                throw new EventoException("iserisci un numero positivo");
            }
            else
            {
                _capienzaEvento = value;
            }



        }
    }
    public int NumeroPostiPrenotati { get; private set; }

    public int PostiDisponibili
    {
        get
        {
            return _postiDisponibili = CapienzaEvento - NumeroPostiPrenotati;    
        }
 
}    
            
            
            

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


        return NumeroPostiPrenotati = NumeroPostiPrenotati + postiPrenotati;
        
        
    }

    //public int DisponibilitàPosti(int postidisponibili)
    //{
    //    int postiPrenotati = PrenotaPosti(postidisponibili);
    //    int postiDisponibili = 0;
    //    if (_postiDisdetti == 0) 
    //        return postiDisponibili = CapienzaEvento - postiPrenotati;

    //    return postiDisponibili + _postiDisdetti;
    //}

 

    public int DisdiciPosti(int postiDisdetti)
    {
        //permette di disdire i posti prenotati
        if (Data < DateTime.Today || postiDisdetti > NumeroPostiPrenotati)
            throw new Exception("errore");
        
        return NumeroPostiPrenotati = NumeroPostiPrenotati - postiDisdetti; 
       
    }

    public override string ToString()
    {
        //restituisce la data e il titolo dell'evento
        return Data.ToString("dd/MM/yyyy") + " " + Titolo;
    }


}
