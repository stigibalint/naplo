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
using System.IO;
namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sliJegy.Value = 3;
            dpDatum.SelectedDate = DateTime.Now;
        }

        private void sliJegy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblValtozo.Content = Math.Round(sliJegy.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter fjl = new StreamWriter("naplo.csv", true);
            fjl.WriteLine(txtNev.Text.ToString() + ";" + cboTantargy.Text + ";", dpDatum.Text.ToString() + ";" + sliJegy.Value.ToString());
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
