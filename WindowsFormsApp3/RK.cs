using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class RK
    {
        static public ComboBox text1, text2;
        static public string theFirst, theSecond;

        static public bool check;
        static public void lango()
        {
            check = false;
            if(text1.Text== "азербайджанский")
            {
                theFirst = "az";
                check = true;
            }
            if (text1.Text == "албанский")
            {
                theFirst = "sq";
                check = true;
            }
            if (text1.Text == "амхарский")
            {
                theFirst = "am";
                check = true;
            }

            if (text1.Text == "английский")
            {
                theFirst = "en";
                check = true;
            }
            if (text1.Text == "арабский")
            {
                theFirst = "ar";
                check = true;
            }
            if (text1.Text == "армянский")
            {
                theFirst = "hy";
                check = true;
            }
            if (text1.Text == "китайский")
            {
                theFirst = "zh";
                check = true;
            }
            if (text1.Text == "иврит")
            {
                theFirst = "he";
                check = true;
            }
            if (text1.Text == "латынь")
            {
                theFirst = "la";
                check = true;
            }
            if (text1.Text == "русский")
            {
                theFirst = "ru";
                check = true;
            }
            if (text1.Text == "французский")
            {
                theFirst = "fr";
                check = true;
            }
            if (text1.Text == "японский")
            {
                theFirst = "ja";
                check = true;
            }

            if (check == false)
            {
                theFirst = "ru";
            }
            
        }

        static public void langtw()
        {
            if (text2.Text == "азербайджанский")
            {
                theSecond = "az";
            }
            if (text2.Text == "албанский")
            {
                theSecond = "sq";
            }
            if (text2.Text == "амхарский")
            {
                theSecond = "am";
            }

            if (text2.Text == "английский")
            {
                theSecond = "en";
            }
            if (text2.Text == "арабский")
            {
                theSecond = "ar";
            }
            if (text2.Text == "армянский")
            {
                theSecond = "hy";
            }
            if (text2.Text == "китайский")
            {
                theSecond = "zh";
            }
            if (text2.Text == "иврит")
            {
                theSecond = "he";
            }
            if (text2.Text == "латынь")
            {
                theSecond = "la";
            }
            if (text2.Text == "русский")
            {
                theSecond = "ru";
            }
            if (text2.Text == "французский")
            {
                theSecond = "fr";
            }
            if (text2.Text == "японский")
            {
                theSecond = "ja";
            }
        }

    }
}
