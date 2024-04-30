namespace _11_Reflections.Modelo
{
    public class Usuario : ICloneable
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public object Clone()
        {
           return new Usuario() { Nome = Nome, Email = Email, Senha = Senha };
        }
    }
}
