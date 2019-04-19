using Aplicacao;
using System;
using System.Windows.Forms;

namespace TCC_Novo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Twilio.TwilioClient.Init("AC4c80c2fc96db20c4e9c3cfa0dc3e8c5a", "044a9727a7f33e2fad933a0b29f508bc");           
        }

        private void envsms_Click(object sender, EventArgs e)//enviar sms
        {
            //SMS sms = new SMS();

            //sms.EnviarTwilio();
            //sms.sendMessage();
        }

        private void button1_Click(object sender, EventArgs e)//quebrar captcha
        {
            TwoCaptchaClient cap = new TwoCaptchaClient("176fdd973bc4ffc72b72d327b1aeb8a6");

            cap.SolveRecaptchaV2("6LeJOzMUAAAAAMxYRUSoKwySawDtIarnMxUR8fJq", "http://consultas.detrannet.sc.gov.br/servicos/consultaveiculo.asp?placa=XXX0000&renavam=1234567890", "HTTP", ProxyType.HTTP);
        }

        private void button2_Click(object sender, EventArgs e)//teste
        {
            TwoCaptchaClient cap = new TwoCaptchaClient("176fdd973bc4ffc72b72d327b1aeb8a6");

            cap.Teste("http://www.google.com");
        }
    }
}
