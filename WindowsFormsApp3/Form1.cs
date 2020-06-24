using System;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using xNet;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       
     

        public Thread bang;

        public Form1()
        {
            InitializeComponent();
            detectedLanguage.text1 = textBox1;
            detectedLanguage.text3 = richTextBox1;
         

            translating.rich = richTextBox1;

            speller.message = textBox3;
            speller.text = textBox2;

            RK.text1 = comboBox1;
            RK.text2 = comboBox2;
        }


      

        private void Form1_Load(object sender, EventArgs e)
        {
            
           comboBox1.Text= comboBox1.Items[0].ToString();

            comboBox2.Text = comboBox2.Items[3].ToString();
            RK.lango();
            RK.langtw();


            textBox4.Text = Properties.Resources.speller;
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void sPELLERNotSpinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  userControl11.Visible = true;
            panel1.Visible = true;
           
        }

        

      

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== comboBox1.Items[0].ToString()) {
                //if (bang.IsAlive)
                //    bang.Abort();
                MessageBox.Show("if");
               RK.langtw();
              
                detectedLanguage.deteck();
                translating.translate();
            }
            else
            {

                detectedLanguage.dec();
                RK.lango();
                RK.langtw();
             
                translating.translatNOT();
              
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            speller.spool();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
