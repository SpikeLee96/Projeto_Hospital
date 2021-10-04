using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Models
{
    public class TipoExame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long id { get; set; }

        [Display(Name = "Tipo do exame")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Requerido no mínimo 5 e no máximo 100 caracteres!")]
        public string tipo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "Requerido no mínimo 5 e no máximo 256 caracteres!")]
        public string descricao { get; set; }
        public virtual ICollection<Exame> Exame { get; set; }
    }
}
