using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Compromisso
    {
        public int ID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public String Titulo { get; set; }

        [MaxLength(500)]
        public String Local { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        [InverseProperty("Compromissos")]
        public IList<Contato> Participantes { get; set; }



    }
}
