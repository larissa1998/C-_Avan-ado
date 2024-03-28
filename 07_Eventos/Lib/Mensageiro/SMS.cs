using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine("SMS enviado para o video: " + args.Video.Nome);
        }
    }
}
