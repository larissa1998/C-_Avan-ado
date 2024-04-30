using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Atributo
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo Nome é de preenchimento obrigatório simples")]
        public string Nome { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO"]
        [EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(10, MinimumLength = 6)]
        [MyValidacao]
        public string Senha { get; set; }
    }
}
