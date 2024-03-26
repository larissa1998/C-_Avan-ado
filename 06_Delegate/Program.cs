
using _06_Delegate.Lib;
using System;

namespace _06_Delegate
{
    public class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            // Tela - Cadastro de Usuário: Thumb (Foto de Perfil)
            Foto foto = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto);

            // Tela - Cadastro de Produtos: Colorir + Tamanho Medio
            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros = new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processador(foto2);

            // Tela - Cadastro de Albuns do Usuario - Retro: Preto e Branco
            Foto foto3 = new Foto() { Nome = "usuario.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros = new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processador(foto3);

            Console.ReadKey();

            /*Espécia de ponteiro (referência), para realizar chamadas mais simples de métodos não reconhecidos, entre outros*/
           
            /* MÉTODO TRADICIONAL
                var so = Soma(10, 20);

                var su = Subtrair(20, 10);            
            */

            /*Com DELEGATE*/
            Calcula calc = new Calcula(Soma);
            int so = calc(10, 20);

            Calcula calc2 = new Calcula(Subtrair); //ponteiro chamando um método
            int su = calc2(30, 15);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Subtrair: " + su);
            
            Console.ReadKey();
        }
        
        static int Soma (int a , int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
