namespace ClassLib;

public class Medewerker
{
    public int Afdelingen { get; set; }
    public int Chef { get; set; }
    public float Comm { get; set; }
    public string Functie { get; set; }
    public DateTime GebDatum { get; set; }
    public float Maandsalaris { get; set; }
    public int MnrID { get; set; }
    public string Naam { get; set; }
    public string Voornaam { get; set; }

    public Medewerker()
    {
        
    }
    
    public Medewerker(int afdelingen, int chef, float comm, string functie, DateTime gebDatum, float maandsalaris, int mnrId, string naam, string voornaam)
    {
        Afdelingen = afdelingen;
        Chef = chef;
        Comm = comm;
        Functie = functie;
        GebDatum = gebDatum;
        Maandsalaris = maandsalaris;
        MnrID = mnrId;
        Naam = naam;
        Voornaam = voornaam;
    }
}