// See https://aka.ms/new-console-template for more information



//MILESTONE 1

using System.Linq.Expressions;

public class Evento
{
    string _titolo;
    int _capienzaEvento;
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
            if (_titolo == null || _titolo == "")   
                throw new Exception();
           
            
                _titolo = value;
            
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
            if (_dataevento < DateTime.Today)
            
                throw new Exception(); 
            

                _dataevento = value;
            
        }
    }



    public int CapienzaEvento {
        get
        {
            return _capienzaEvento;
        }

        private set 
        { 
            if(_capienzaEvento < 0)
                throw new Exception();
            
            _capienzaEvento = value;
            
        } 
    }
    public int NumeroPostiPrenotati { get; private set; }

    public Evento()
    {

    }

    public Evento(string titolo, DateTime dataevento, int capienzaEvento)
    {
        _titolo = titolo;
        _dataevento = dataevento;
        _capienzaEvento = capienzaEvento;
        NumeroPostiPrenotati = 0;
    }

    public int PrenotaPosti(int postiPrenotati) 
    {
        //PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.Se
        if (Data < DateTime.Now || postiPrenotati > CapienzaEvento)
            throw new Exception("errore");
        

        return NumeroPostiPrenotati + postiPrenotati;
        
        
    }

    public int DisponibilitàPosti(int postidisponibili)
    {
        int postiPrenotati = PrenotaPosti(postidisponibili);

        return CapienzaEvento - postiPrenotati;
    }

 

    public int DisdiciPosti(int postiDisdetti)
    {
        //permette di disdire i posti prenotati
        if (Data < DateTime.Now || postiDisdetti > NumeroPostiPrenotati)
            throw new Exception("errore");
        
        return NumeroPostiPrenotati - postiDisdetti;
       
    }

    public override string ToString()
    {
        //restituisce la data e il titolo dell'evento
        return Data.ToString("dd/MM/yyyy") + " " + Titolo;
    }


}
