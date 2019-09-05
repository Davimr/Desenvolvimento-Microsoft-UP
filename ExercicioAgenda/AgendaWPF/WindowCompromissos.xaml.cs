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
    /// Lógica interna para WindowCompromissos.xaml
    /// </summary>
    public partial class WindowCompromissos : Window
    {
        public ViewModel.AgendaViewModel AgendaViewModel { get; set; }
        public WindowCompromissos()
        {
            InitializeComponent();
            this.AgendaViewModel = new ViewModel.AgendaViewModel();
            this.DataContext = this;
        }

        private void Fechar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Adicionar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.AdicionarCompromisso();
        }

        private void Remover_Button_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.RemoverCompromisso();
        }

        private void Salvar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.Salvar();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.CompromissoSelecionado.Participantes.Add(this.AgendaViewModel.ContatoSelecionado);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.CompromissoSelecionado.Participantes.Remove(this.AgendaViewModel.ParticipanteSelecionado);
        }
    }
}
