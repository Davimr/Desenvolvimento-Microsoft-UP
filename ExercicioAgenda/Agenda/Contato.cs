using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public String Nome { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public String Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        [MaxLength(20)]
        public String Telefone { get; set; }

        [InverseProperty("Participantes")]
        public IList<Compromisso> Compromissos { get; set; }



    }
}
