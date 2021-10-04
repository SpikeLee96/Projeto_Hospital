using Projeto_CRUD.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Models
{
    public class Paciente
    {
        private const string expressaoTelefone = @"^[1-9]{2}(?:[2-8]|9[1-9])[0-9]{3}[0-9]{4}$";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Requerido no mínimo 5 e no máximo 100 caracteres!")]
        [RegularExpression(@"^([\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+((\s[\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+)?", ErrorMessage = "Permitido somente letras maiúsculas e minúsculas!")]
        public string nome { get; set; }
        /*
        [Required(ErrorMessage = "por favor preencha o campo!")]
        public string senha { get; set; }
        */
        [Display(Name = "Cadastro de Pessoa Física (CPF)")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [CustomValidationCPF(ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida!")]
        public DateTime data { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        public string sexo { get; set; }

        [Display(Name = "Telefone (com DDD, somente números)")]
        [RegularExpression(expressaoTelefone, ErrorMessage = "Número de telefone inválido")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        public string telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "por favor preencha o campo!")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido!")]
        public string email { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }

    }
}
