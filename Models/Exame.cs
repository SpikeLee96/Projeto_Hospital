using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Models
{
    public class Exame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long id { get; set; }

        [Display(Name = "Nome do Exame")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Requerido no mínimo 5 e no máximo 100 caracteres!")]
        public string nomeExame { get; set; }

        [Display(Name = "Observações")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Requerido no mínimo 5 e no máximo 1000 caracteres!")]
        public string observacoes { get; set; }
        public long TipoExameId { get; set; }
        [ForeignKey("TipoExameId")]
        public virtual TipoExame TipoExame { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
