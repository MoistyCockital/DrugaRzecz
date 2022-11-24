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

namespace DrugaRzecz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tekstBlok.Text = "Tekst generowany z C#";
            tekstPudlo.Text = "Tekst TextBox wygenerowany z C#";
        }

        private void Przepisz_Click(object sender, RoutedEventArgs e)
        {
            string tekst = tekstPudlo.Text.ToString();
            tekstBlok2.Text = tekst;
        }
    }
}
