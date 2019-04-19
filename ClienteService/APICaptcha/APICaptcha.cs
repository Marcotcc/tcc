using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class APICaptcha
    {
        public string SendRecaptchav2Request()
        {
            //POST
            try
            {
                System.Net.ServicePointManager.Expect100Continue = false;
                var request = (HttpWebRequest)WebRequest.Create("http://2captcha.com/in.php");
                                //"key=2captcha API KEY&method=userrecaptcha&googlekey=GOOGLE KEY";//&pageurl=yourpageurl"; ;
                var postData = "key=176fdd973bc4ffc72b72d327b1aeb8a6&method=userrecaptcha&googlekey=6LeJOzMUAAAAAMxYRUSoKwySawDtIarnMxUR8fJq&pageurl=http://consultas.detrannet.sc.gov.br/servicos/consultaveiculo.asp?placa=XXX0000&renavam=1234567890";
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //  GET
                if (responseString.Contains("OK|"))
                {
                    return responseString.Substring(0, 3);
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception e)
            {
                string tt = e.Message;
                return tt;
            }
        }
    }
}
