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

        public Contato ContatoSelecionado { get; set; }

        public Compromisso CompromissoSelecionado { get; set; }

        public IList<Contato> ParticipantesCompromisso { get; set; }

        public ModelAgenda modelAgenda = new ModelAgenda();

        public AgendaViewModel()
        {
            this.Contatos = new ObservableCollection<Contato>(modelAgenda.Contatos.ToList());
            this.ContatoSelecionado = modelAgenda.Contatos.FirstOrDefault();

            this.Compromissos = new ObservableCollection<Compromisso>(modelAgenda.Compromissos.ToList());
            this.CompromissoSelecionado = modelAgenda.Compromissos.FirstOrDefault();

            this.CompromissoSelecionado.Participantes.Add(Contatos.FirstOrDefault());

            this.ParticipantesCompromisso = CompromissoSelecionado.Participantes;
        }


        public Boolean PodeSalvarData
        {
            get
            {
                return this.ContatoSelecionado.DataNascimento.Date <= DateTime.Now;
            }
        }

        public void Salvar()
        {
            this.modelAgenda.SaveChanges();
        }

        public void RemoverContato()
        {
            if (this.ContatoSelecionado.ID != 0)
            {
                this.modelAgenda.Contatos.Remove(ContatoSelecionado);
                this.Contatos.Remove(ContatoSelecionado);
                this.modelAgenda.SaveChanges();
            }
        }

        public void RemoverCompromisso()
        {
            if (this.CompromissoSelecionado.ID != 0)
            {
                this.modelAgenda.Compromissos.Remove(CompromissoSelecionado);
                this.Compromissos.Remove(CompromissoSelecionado);
            }
        }

        public void AdicionarContato()
        {
            Contato c = new Contato();
            this.Contatos.Add(c);
            this.ContatoSelecionado = c;
            this.modelAgenda.Contatos.Add(c);
        }

        public void AdicionarCompromisso()
        {
            Compromisso co = new Compromisso();
            this.Compromissos.Add(co);
            this.CompromissoSelecionado = co;
            this.modelAgenda.Compromissos.Add(co);
        }
    }
}
