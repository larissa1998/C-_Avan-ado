namespace _08_ThreadResets
{
    class Program
    {
        static ManualResetEvent manual01; //parecido semaforo false = vermelho e true verde. Tem que fazer o reset para fazer o travamento
        static AutoResetEvent auto01; //nao precisa o reset. O reset é automatico
        static void Main(string[] args) {

            manual01 = new ManualResetEvent(false);

            Thread t1 = new Thread(Executar1);
            t1.Start();

            Thread t2 = new Thread(Executar2);
            t2.Start();

            Console.ReadKey();
        }

        static void Executar1()
        {
            Console.WriteLine("01 TESTE");
            manual01.WaitOne();
        }

        static void Executar2()
        {
            Console.WriteLine("02 TESTE");
        }
    }
}