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
    /// Logika interakcji dla klasy ObliczeniaWindow.xaml
    /// </summary>
    public partial class ObliczeniaWindow : Window
    {
        public ObliczeniaWindow()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(Liczba1.Text, out int a) && int.TryParse(Liczba2.Text, out int b))
            {
                int suma = a + b;
                MessageBox.Show("Suma "+a+" i "+b+" wynosi "+suma.ToString(), "Wynik", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else{
                MessageBox.Show("Musi być wypełniony formularz poprawnie","Uwaga",MessageBoxButton.OK, MessageBoxImage.Warning);
                //To jest okno modalne ;o
            }
        }
    }
}
