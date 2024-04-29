using System.Net;

namespace _09_Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(lista.ToArray());


            string[] enderecos = new string[] { "http://www.google.com.br", "http://www.microsoft.com.br" };
            var listaEdn = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listaEdn.ToArray());

            Console.WriteLine("Finalizado");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor" + i + "TaskID: " + Task.CurrentId);
            }
        }

        static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Donwload Para a pagina" + end);
        }
    }
}