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

namespace OOP_Clovek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Clovek karel;
        Clovek jan;
        public MainWindow()
        {
            InitializeComponent();
            karel = new Clovek();
            karel.Jmeno = "Karel";
            karel.Prijmeni = "Cvrcek";
            karel.DatumNarozeni = new DateTime(2006, 5, 24);
            Zobraz(karel, txtBox1);
            
            jan = new Clovek();
            jan.Jmeno = "Jan";
            jan.Prijmeni = "28";
            Zobraz(jan, txtBox2);
        }

        public void Zobraz(Clovek clovek, TextBox textBox)
        {
            textBox.Text = clovek.Jmeno + " " + clovek.Prijmeni + "\n";
            textBox.Text += clovek.DatumNarozeni.ToString() + "\n";
            textBox.Text += "Život" + clovek.Zivot.ToString() + "\n";
            textBox.Text += "Energie" + clovek.Energie.ToString() + "\n";
            textBox.Text += "Dovednost" + clovek.Dovednost.ToString() + "\n";

        }

        private void PosuňČas_Click(object sender, RoutedEventArgs e)
        {
            karel.Zestarnout();
            jan.Zestarnout();
            Zobraz(karel, txtBox1);
            Zobraz(jan, txtBox2);





        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            karel.Zvysitdovednosti();
            jan.Zvysitdovednosti();
            Zobraz(karel, txtBox1);
            Zobraz(jan, txtBox2);

        }
    }
}
