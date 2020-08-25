using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddenPairGame
{
    public partial class Form2 : Form
    {
        User user1 = new User();
        private Form1 form1;
        public Form2(Form1 glowna)
        {
            InitializeComponent();
            form1 = glowna;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(textBoxNameUser.TextLength == 0)
            {
                MessageBox.Show("You didn't enter the name!");
            }
            else if(textBoxNameUser.TextLength <= 3)
            {
                MessageBox.Show("You name must be longer than 3 character!");
            }
            else
            {
                user1.nameUser = textBoxNameUser.Text;
                Game game = new Game(form1, user1);
                game.Show();
                this.Close();
            }
            
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Visible = true;
           
        }
    }
}
