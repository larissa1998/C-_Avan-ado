
using System.Text.Json;
namespace _01_Generics.Modelo
{
    public class Serializador
    {
        public static void Serializar(Object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Larissa\source\repos\Arquivos C# Avançado\03_" + obj.GetType().Name + ".txt");

            var serializador = JsonSerializer.Serialize(obj);

            sw.Write(serializador);

            sw.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Larissa\source\repos\Arquivos C# Avançado\03_" + typeof(T).Name + ".txt");

            string conteudo = sr.ReadToEnd();

            var obj = JsonSerializer.Deserialize<T>(conteudo);

            return obj;
        }
    }
}
