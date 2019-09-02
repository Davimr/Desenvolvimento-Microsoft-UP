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

namespace AgendaWPF
{
    /// <summary>
    /// Lógica interna para WindowContatos.xaml
    /// </summary>
    public partial class WindowContatos : Window
    {
        public WindowContatos()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Salvar_Button_Click(object sender, RoutedEventArgs e)
        {
            //
            this.Close();
        }

        private void Adicionar_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remover_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
