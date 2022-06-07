using System.Data;
using System.Data.SqlClient;

namespace ClassLib;

public class DBConnect
{
    public static DataTable medewerkerDataTable { get; set; }


    public static SqlConnection MakeConnection()
    {
        string connectionString = @"Server=DESKTOP-NBJ1D2D;Database=Medewerkers;Integrated security=true";
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
    }
    
    public static void MaakConnectie()
    {
        string connectionString = @"Server=DESKTOP-NBJ1D2D;Database=Medewerkers;Integrated security=true";
        
        using (SqlConnection connection = new SqlConnection(connectionString))
        {   
            connection.Open();
            using (SqlCommand command = new SqlCommand("select * from Medewerkers" , connection))
            {
                medewerkerDataTable = new DataTable();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(medewerkerDataTable);
                }
            }
        }
        
    }
}