using System.Net;

namespace _09_Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            //Task.Run(() => Metodo01());
            string endereco = txtSite.Text;

            WebClient web = new WebClient();
            string html =  web.DownloadString(endereco);
            //string html = await web.DonwloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;
        }
    }
}