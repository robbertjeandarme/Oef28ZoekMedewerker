using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLib;

namespace Oef28ZoekMedewerker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
        }

        private void LaadDataTable()
        {
            DBConnect.MaakConnectie();
            var dt = DBConnect.medewerkerDataTable;
        }
        
        private void BtnZoeken_OnClick(object sender, RoutedEventArgs e)
        {
            var nmr = TxtMnr.Text;
            DBMedewerker dbMedewerker = new DBMedewerker();
            var mede = dbMedewerker.ZoekMnr(Convert.ToInt32(nmr));

            TxtNaam.Text = mede.Naam;
            TxtMnr.Text = mede.MnrID.ToString();
            TxtAfdeling.Text = mede.Afdelingen.ToString();
            TxtMaandsal.Text = mede.Maandsalaris.ToString();
            TxtComm.Text = mede.Comm.ToString();
            TxtChef.Text = mede.Chef.ToString();
            TxtFunctie.Text = mede.Functie.ToString();
            TxtGebDatum.Text = mede.GebDatum.ToString();
            TxtVoornaam.Text = mede.Voornaam.ToString();
        }
    }
}