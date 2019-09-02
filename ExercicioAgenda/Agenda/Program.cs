using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            Contato contato1 = new Contato()
            {
                Nome = "Marcos",
                Sobrenome = "Paulo",
                DataNascimento = DateTime.Now,
                Telefone = "41 988407295"
            };

            Contato contato2 = new Contato()
            {
                Nome = "Jose",
                Sobrenome = "Bezerra",
                DataNascimento = DateTime.Now,
                Telefone = "41 88438765"
            };

            Compromisso compromisso1 = new Compromisso()
            {
                Titulo = "É um compromisso de compra com o vendedor.",
                Local = "Avenida Sete de setembro Bairro Batel Numero 4476",
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now
            };

            Compromisso compromisso2 = new Compromisso()
            {
                Titulo = "Venda da moto da minha tia.",
                Local = "Rua dos passaros Bairro Xaxim Numero 432",
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now
            };

            compromisso1.Participantes = new List<Contato>();
            compromisso2.Participantes = new List<Contato>();

            contato1.Compromissos = new List<Compromisso>();
            contato2.Compromissos = new List<Compromisso>();

            compromisso1.Participantes.Add(contato1);
            compromisso1.Participantes.Add(contato2);

            compromisso2.Participantes.Add(contato1);

            contato1.Compromissos.Add(compromisso1);
            contato1.Compromissos.Add(compromisso2);

            contato2.Compromissos.Add(compromisso1);

            ModelAgenda context = new ModelAgenda();

            context.Contatos.Add(contato1);
            context.Contatos.Add(contato2);

            context.Compromissos.Add(compromisso1);
            context.Compromissos.Add(compromisso2);

            context.SaveChanges();
        }
    }
}
