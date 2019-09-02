using Agenda;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWPF.ViewModel
{
    public class AgendaViewModel
    {
        public ObservableCollection<Contato> Contatos { get; set; } 

        public ObservableCollection<Compromisso> Compromissos { get; set; }
    }
}
