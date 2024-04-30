using _11_Reflections.Modelo;

namespace _11_Reflections
{
    class Program
    {
        public static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Jose",
                Email = "jose@gmail.com",
                Senha = "1234"
            };

            Log.GravarUsuario(usuario);

            usuario.Nome = "Jose costa";
            Log.GravarUsuario(usuario);

            Console.WriteLine("Log gravado!");
            Console.ReadKey();
        }
    }
}