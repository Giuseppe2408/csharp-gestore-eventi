// See https://aka.ms/new-console-template for more information
//Creare una classe Conferenza che estende Evento, che ha anche gli attributi: 
//●relatore: string
//●prezzo: double
//Aggiungere questi attributi nel costruttore e implementarne getter e setter 
//Aggiungere i metodi per restituire data e ora formattata e prezzo formattato (##,## 
//euro). Per farlo vi suggerisco di usare il metodo prezzo.ToString("0.00").
//Fate l’override del metodo ToString() in modo che venga restituita una stringa del 
//tipo: data - titolo - relatore - prezzo formattato.


public class Conferenza : Evento
{
    string Relatore { get; set; }
    double Prezzo { get; set; }



    public Conferenza(string titolo, DateTime dataevento, int capienzaEvento, string relatore, double prezzo) : base(titolo, dataevento, capienzaEvento)
    {
        Relatore = relatore;
        Prezzo = prezzo;
    }


    
    public string StringaData()
    {
        return Data.ToString("dd/MM/yyyy H:m:i") + " ";

    }

    public string StringaPrezzo()
    {
        return Prezzo.ToString("0.00");
    }

    public override string ToString()
    {
         return StringaData() + " - " + " - " + Titolo + Relatore + " - " + StringaPrezzo();
    }

}
