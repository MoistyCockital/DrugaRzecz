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
using System.Windows.Shapes;

namespace DrugaRzecz
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKwadrat.xaml
    /// </summary>
    public partial class WindowKwadrat : Window
    {
        public WindowKwadrat()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(bok.Text, out double a) && a > 0)
            {
                Komunikat.Text = "";
                double obw = a * 4;
                double pol = a * a;
                pole.Text = pol.ToString();
                obwod.Text = obw.ToString();
            }
            else
                Komunikat.Text = "Liczba jest nie poprawna";
        }
    }
}
