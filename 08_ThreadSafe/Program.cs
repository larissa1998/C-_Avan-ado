namespace _08_ThreadSafe
{
    class Program
    {
        //IO - input/output (processo lento) - Tela, Rede, Armazenamento
        static int Rede = 0;
        static object variavelDeControle = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("DataIni " + DateTime.Now);

            for(int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true; //segundo plano
                t1.Start();
            }

            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle) // só libero os recursos depois do for terminar
                {
                    Console.WriteLine("Num " + i);
                    Rede++;
                }
            }

            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}