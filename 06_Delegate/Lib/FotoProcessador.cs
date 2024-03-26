namespace _06_Delegate.Lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processador(Foto foto)
        {
            //var filtros = new FotoFiltro();
            //filtros.Colorir(foto);
            //filtros.PretoBranco(foto);
            //filtros.GerarThumb(foto);
            //filtros.RedimensionarTamMedio(foto);
            filtros(foto);
        }
    }
}
