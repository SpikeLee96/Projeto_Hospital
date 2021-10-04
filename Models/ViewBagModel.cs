using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Models
{
    public class ViewBagModel
    {
        [Required(ErrorMessage = "Preencha o campo!")]
        public string msg { get; set; }
        public string msg2 { get; set; }
    }
}
