using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace WindowsFormsApp3
{
    class speller
    {
        static public TextBox text, message = new TextBox();
        static public string get, test ,brut= null;
        static public int kol;
   
            
        static public void spool()
        {
            test = text.Text;

            var post = new xNet.HttpRequest();
            //  var por = new xNet.HttpResponse();
            try { 
            get = post.Get("https://speller.yandex.net/services/spellservice.json/checkText?text="+test).ToString();
                var mar = JArray.Parse(get);
                JToken spell = mar[0]["s"];
                kol = spell.Count();

                for (int j = 0; j < kol; j++)
                {
                    if (j != kol)
                        brut += spell[j] + ", ";
                    else
                        brut += spell[j] + ". ";
                }




                message.Invoke((MethodInvoker)(() => message.Text = brut));
                brut = null;
            }
            catch
            {
                MessageBox.Show("Проверьте подключение к сети");
            }


            

         
            
           
        }
    }
}
