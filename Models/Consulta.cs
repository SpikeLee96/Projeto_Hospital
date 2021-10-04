using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Projeto_CRUD.Models
{
    public class Consulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Display(Name = "Data de exame")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida!")]
        public DateTime data { get; set; }
        public long ExameId { get; set; }
        public long PacienteId { get; set; }
        [ForeignKey("ExameId")]
        public virtual Exame Exame { get; set; }
        [ForeignKey("PacienteId")]
        public virtual Paciente Paciente { get; set; }
    }
}
