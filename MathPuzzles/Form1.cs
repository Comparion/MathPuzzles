using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddenPairGame
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            buttonBack.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Points are calculated according to the formula: level * 100 / round time");
            buttonPlay.Visible = false;
            buttonExit.Visible = false;
            buttonRanking.Visible = false;
            button1.Visible = false;
            buttonBack.Visible = true;
            label1.Visible = true;


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = true;
            buttonExit.Visible = true;
            buttonRanking.Visible = true;
            button1.Visible = true;
            buttonBack.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            label4.Text = null;
            buttonPlay.Visible = false;
            buttonExit.Visible = false;
            buttonRanking.Visible = false;
            button1.Visible = false;
            buttonBack.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            try
            {
                using (StreamReader streamR = new StreamReader(("wynik.txt"), true))
                {
                    string text;
                    while((text = streamR.ReadLine()) != null)
                    {
                        label4.Text = label4.Text + text + "\n\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The ranking could not be read. " + ex.Message);
            }
        }
    }
}
