namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //compilação
            object t1 = "";
            object t2 = 12345;
            t2 = ""; //
            //((object)t1).Nome;

            var v1 = "";
            var v2 = 12345;
            //var v3
            //v2 = ""

            dynamic d1 = new Usuario { Nome = "Maria" }; //execução - qualquer tipo

            Console.WriteLine(d1.Nome);
            Console.WriteLine(d1.Senha);//erro

            d1 = "";

            Console.ReadKey();
        }
    }

    class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set;}
    }
}