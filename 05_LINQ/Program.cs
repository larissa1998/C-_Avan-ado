namespace _05_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* LINQ E LAMBDA COM OBJ E SEM
             
                List<Usuario> list = new List<Usuario>();
                list.Add(new Usuario() { Nome = "Jose", Email = "jose@gmail.com"});
                list.Add(new Usuario() { Nome = "Felipe", Email = "felipe@gmail.com"});
                list.Add(new Usuario() { Nome = "Maria", Email = "maria@gmail.com"});
                list.Add(new Usuario() { Nome = "Rosana", Email = "rosana@hotmail.com"});
                list.Add(new Usuario() { Nome = "Mariana", Email = "mariana@hotmail.com"});
             
            
                var listaFiltrada = lista.Where(a => a > 10).Select(a => a);

                var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

                var listaFiltrada = from a in lista where a > 10 orderby a select a;

                var listaFiltrada = list.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(a=>a);

                foreach ( var item in listaFiltrada ) { 
                    Console.WriteLine(item); 
                }

                foreach (var item in listaFiltrada)
                {
                    Console.WriteLine(item.Nome + " - " +  item.Email);
                }

                Console.ReadKey();
            */

            /*
            LINQ JOIN e GROUP
            List<Author> listaAutor = new List<Author>();

            listaAutor.Add(new Author() { Id = 1 , Nome = "Leonardo" });
            listaAutor.Add(new Author() { Id = 2 , Nome = "Maria maria" });
            listaAutor.Add(new Author() { Id = 3 , Nome = "Joseph" });

            List<Livro> listaLivro = new List<Livro>();

            listaLivro.Add(new Livro() {  Id = 1 , AutorId = 2, Titulo = "Amor amado" });
            listaLivro.Add(new Livro() {  Id = 2 , AutorId = 2, Titulo = "Bem amado" });
            listaLivro.Add(new Livro() {  Id = 3 , AutorId = 3, Titulo = "Um espião em Washington" });
            listaLivro.Add(new Livro() {  Id = 4 , AutorId = 1, Titulo = "A vida na terra" });

            var listaJoin = from livros in listaLivro
                            join autor in listaAutor
                            on livros.AutorId equals autor.Id
                            select new { livros, autor };

            foreach( var item in listaJoin)
            {
                Console.WriteLine("livro: " + item.livros.Titulo + " - Autor: " + item.autor.Nome);
            }
            */

            /*GROUP
             int[] listaNum = { 1,1,1,1,4,4,2,3,5,6,6,10,9,8 };

            GROUP distinct
            var listaFiltrada = listaNum.Distinct().OrderBy(a=>a);

            GROUP BY
            var listaFiltrada = listaNum.OrderBy(a=>a).GroupBy(a=>a).Select(a=>a);

            foreach(var item in listaNum){
                Console.WriteLine(item.Key);
            }
            */
        }
    }
}