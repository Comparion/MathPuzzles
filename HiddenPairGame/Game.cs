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
    public partial class Game : Form
    {
        int mm = 0;
        int ss = 1;
        int totalTime=1;
        int number1, number2, sign;
        int level = 1;
        int result;
        int lossField;
        User player;
        private Form1 form1;
        Random rnd = new Random();
        Timer t = new Timer();
        public Game(Form1 glowna, User user1)
        {
            InitializeComponent();
            form1 = glowna;
            player = user1;
            label1.Text = user1.nameUser;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            label5.Text = ContentQuestion();
            LossField();
        }

        private int LossSign2()
        {
            return rnd.Next(1, 3);
        }

        private void LossField()
        {
            int sign2, number3; 
            lossField = rnd.Next(1, 5);
            if (lossField == 1)
            {
                button2.Text = result.ToString();
                sign2 = LossSign2();
                if(sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button3.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button3.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button4.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button4.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button5.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button5.Text = Math.Abs((result - number3)).ToString();
                }
            }
            if (lossField == 2)
            {
                button3.Text = result.ToString();
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button4.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button4.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button2.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button2.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button5.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button5.Text = Math.Abs((result - number3)).ToString();
                }
            }
            if (lossField == 3)
            {
                button4.Text = result.ToString();
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button3.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button3.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button2.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button2.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button5.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button5.Text = Math.Abs((result - number3)).ToString();
                }
            }
            if (lossField == 4)
            {
                button5.Text = result.ToString();
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button3.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button3.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button4.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button4.Text = Math.Abs((result - number3)).ToString();
                }
                sign2 = LossSign2();
                if (sign2 == 1)
                {
                    number3 = rnd.Next(1, 11) * level;
                    button2.Text = (result + number3).ToString();
                }
                else
                {
                    number3 = rnd.Next(1, 11) * level;
                    button2.Text = Math.Abs((result - number3)).ToString();
                }
            }
        }

        private string ContentQuestion()
        {
            string resultString = "empty";
            sign = rnd.Next(1, 5);
            number1 = rnd.Next(10, 20);
            number2 = rnd.Next(10, 20);
            while ((sign == 2 || sign == 4) && number1 < number2)
            {
                number2 = rnd.Next(10, 20);
            }
            while (sign == 4 && (level * number1) % (number2) != 0)
            {
                number2 = rnd.Next(1, 100);
            }
            //addidtion
            if (sign == 1)
            {
                result = (level * number1) + (level * number2);
                resultString = (level * number1)+ " + " + (level * number2);
            }
            //subtraction
            if(sign == 2)
            {
                result = (level * number1) - (level * number2);
                resultString = (level * number1) + " - " + (level * number2);
            }
            //multiplication
            if (sign == 3)
            {
                result = (level * number1) * (level * number2);
                resultString = (level * number1) + " * " + (level * number2);
            }
            //division
            if (sign == 4)
            {
                result = (level * number1) / (number2);
                resultString = (level * number1) + " / " + (number2);
            }
            //result = number1 + (int)actionMath.addition + number2; 
            return resultString;
        }

 
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Visible = true;
        }

        //private void ButtonOperation(Button b1)
        //{

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(totalTime < level * 2 && level > 5)
            {
                MessageBox.Show("You cheat, GAME OVER!");
                    this.Close();
            }
            if(button2.Text.Equals(result.ToString()))
            {
                player.Point = player.Point + (level * 100)/ss;
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
            label2.Text = "Points: " + player.Point;
            label3.Text = "Level " + ++level;
            mm = 0;
            ss = 1;
            label5.Text = ContentQuestion();
            LossField();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Equals(result.ToString()))
            {
                player.Point = player.Point + (level * 100) / ss;
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
            label2.Text = "Points: " + player.Point;
            label3.Text = "Level " + ++level;
            mm = 0;
            ss = 1;
            label5.Text = ContentQuestion();
            LossField();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Equals(result.ToString()))
            {
                player.Point = player.Point + (level * 100) / ss;
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
            label2.Text = "Points: " + player.Point;
            label3.Text = "Level " + ++level;
            mm = 0;
            ss = 1;
            label5.Text = ContentQuestion();
            LossField();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text.Equals(result.ToString()))
            {
                player.Point = player.Point + (level * 100) / ss;
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
            label2.Text = "Points: " + player.Point;
            label3.Text = "Level " + ++level;
            mm = 0;
            ss = 1;
            label5.Text = ContentQuestion();
            LossField();
        }

        //function show time in for mat 00:00 and incrementation seconds
        private void t_Tick(object sender, EventArgs e)
        {
            totalTime++;
            ss++;
            string time = "";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else if(ss == 60)
            {
                ss = 0;
                mm++;
            }
            else
            {
                time += ss;
            }

            label4.Text ="Time: " + time;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
