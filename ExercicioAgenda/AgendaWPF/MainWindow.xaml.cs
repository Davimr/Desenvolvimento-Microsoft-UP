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

namespace AgendaWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

        }


        private void Button_Contato(object sender, RoutedEventArgs e)
        {
            WindowContatos wincontato = new WindowContatos();
            wincontato.Show();

        }

        private void Button_Compromisso(object sender, RoutedEventArgs e)
        {
            WindowCompromissos windowCompromissos = new WindowCompromissos();
            windowCompromissos.Show();
        }

        private void Button_Finalizar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
