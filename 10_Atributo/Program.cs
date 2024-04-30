using System.ComponentModel.DataAnnotations;

namespace _10_Atributo
{
    //explicar ou gerar outra informação codigo
    [MeuAtributo("Atributo classe", Descricao = "Descrição do atributo")]
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose", Email = "jose@gmail.com", Senha = "1234" };
            ValidationContext context = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, context, resultados, true) == false)
            {
                //msgs
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro);
                }
            }

        }
    }
}