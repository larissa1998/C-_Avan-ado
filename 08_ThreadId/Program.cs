namespace _08_ThreadId
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Thread Sleep
                Console.WriteLine("Inicio do programa");
                Thread.Sleep(3000);

                Thread Join
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start();
                t1.Join(); espera a execução da thread t1 para depois continuar
                Console.WriteLine("Inicio do programa");
                Console.WriteLine("Inicio do programa");
                Console.WriteLine("Inicio do programa");
             */

            for (int i = 0; i < 5; i++) {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);
            }
            Console.ReadKey();
        }

        static void ThreadRepeticao(object id)
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + id + " - Num: " + i + "ID Interno: ", Thread.CurrentThread.ManagedThreadId);
            }   
        }
    }
}