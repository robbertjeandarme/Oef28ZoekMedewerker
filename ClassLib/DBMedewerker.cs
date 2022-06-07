using System.Data;
using System.Data.SqlClient;

namespace ClassLib;

public class DBMedewerker
{
    public Medewerker ZoekMnr(int mnr)
    {
        Medewerker ff = new Medewerker();
        string connectionString = @"Server=DESKTOP-NBJ1D2D;Database=Medewerkers;Integrated security=true";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {   
            connection.Open();
            using (SqlCommand command = new SqlCommand("select * from Medewerkers where mnr = @mnr" , connection))
            {
                command.Parameters.Add("@mnr", SqlDbType.Int).Value = mnr;
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ff.MnrID = Convert.ToInt32(dataReader["mnr"]);
                        ff.Naam = dataReader["naam"].ToString();
                        ff.Voornaam = dataReader["voorn"].ToString();
                        ff.Functie = dataReader["functie"].ToString();
                        ff.Chef = Convert.ToInt32(dataReader["chef"]);
                        ff.GebDatum = Convert.ToDateTime(dataReader["gbdatum"]);
                        ff.Maandsalaris = Convert.ToInt32(dataReader["maandsal"]);
                        ff.Comm = Convert.ToInt32(dataReader["comm"]);
                        ff.Afdelingen = Convert.ToInt32(dataReader["afd"]);
                    }
                }
            }
        }
        return ff;
    }
}