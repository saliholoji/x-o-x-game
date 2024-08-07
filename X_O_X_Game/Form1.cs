using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_X_Game
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button10.Enabled = false;
        }
        
        public int i, x1, x2, x3, x4, x5, x6, x7, x8, x9;

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            i = 0;
            x1 = x2 = x3 = x4 = x5 = x6 = x7 = x8 = x9 = 0;
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            button10.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button1.Enabled = false;
            i++;
            if (i % 2 == 1)
            {
                x1 = 5;
                button1.Text = "X";
                if (x1 + x2 + x3 == 15 || x1 + x4 + x7 == 15 || x1 + x5 + x9 == 15)
                {
                    if (x1 + x2 + x3 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button3.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x1 + x4 + x7 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x1 + x5 + x9 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }


            }
            else
            {
                x1 = -5;
                button1.Text = "O";
                if (x1 + x2 + x3 == -15 || x1 + x4 + x7 == -15 || x1 + x5 + x9 == -15)
                {
                    if (x1 + x2 + x3 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button3.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x1 + x4 + x7 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x1 + x5 + x9 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
                x2 = 5;
                button2.Text = "X";
                if (x1 + x2 + x3 == 15 || x2 + x5 + x8 == 15)
                {
                    if (x1 + x2 + x3 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button3.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if(x2 + x5 + x8 == 15)
                    {
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x2 = -5;
                button2.Text = "O";
                if (x1 + x2 + x3 == -15 || x2 + x5 + x8 == -15)
                {
                    if (x1 + x2 + x3 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button3.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x2 + x5 + x8 == -15)
                    {
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button3.Enabled = false;
            i++;
            if (i % 2 == 1)
            {
                x3 = 5;
                button3.Text = "X";
                if (x1 + x2 + x3 == 15 || x3 + x5 + x7 == 15 || x3 + x6 + x9 == 15)
                {
                    if (x1 + x2 + x3 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button3.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x5 + x7 == 15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x6 + x9 == 15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x3 = -5;
                button3.Text = "O";
                if (x1 + x2 + x3 == -15 || x3 + x5 + x7 == -15 || x3 + x6 + x9 == -15)
                {
                    if (x1 + x2 + x3 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button3.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x5 + x7 == -15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x6 + x9 == -15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }

                }
                
            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
                x4 = 5;
                button4.Text = "X";
                if (x1 + x4 + x7 == 15 || x4 + x5 + x6 == 15)
                {
                    if (x1 + x4 + x7 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x4 + x5 + x6 == 15)
                    {
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x4 = -5;
                button4.Text = "O";
                if (x1 + x4 + x7 == -15 || x4 + x5 + x6 == -15)
                {
                    if (x1 + x4 + x7 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x4 + x5 + x6 == -15)
                    {
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
               
                button5.Text = "X";
                x5 = 5;
                if (x1 + x5 + x9 == 15 || x2 + x5 + x8 == 15 || x3 + x5 + x7 == 15 || x4 + x5 + x6 == 15)
                {
                    if (x1 + x5 + x9 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x2 + x5 + x8 == 15)
                    {
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x5 + x7 == 15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x4 + x5 + x6 == 15)
                    {
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
                
            }
            else
            {
                x5 = -5;
                button5.Text = "O";
                if (x1 + x5 + x9 == -15 || x2 + x5 + x8 == -15 || x3 + x5 + x7 == -15 || x4 + x5 + x6 == -15)
                {
                    if (x1 + x5 + x9 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x2 + x5 + x8 == -15)
                    {
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x5 + x7 == -15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x4 + x5 + x6 == -15)
                    {
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
                x6 = 5;
                button6.Text = "X";
                if (x3 + x6 + x9 == 15 || x4 + x5 + x6 == 15)
                {
                    if (x3 + x6 + x9==15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x4 + x5 + x6 == 15)
                    {
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x6 = -5;
                button6.Text = "O";
                if (x3 + x6 + x9 == -15 || x4 + x5 + x6 == -15)
                {
                    if (x3 + x6 + x9 == -15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x4 + x5 + x6 == -15)
                    {
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
                x7 = 5;
                button7.Text = "X";
                if (x1 + x4 + x7 == 15 || x3 + x5 + x7 == 15 || x7 + x8 + x9 == 15)
                {
                    if (x1 + x4 + x7 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x5 + x7 == 15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x7 + x8 + x9 == 15)
                    {
                        this.button7.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x7 = -5;
                button7.Text = "O";
                if (x1 + x4 + x7 == -15 || x3 + x5 + x7 == -15 || x7 + x8 + x9 == -15)
                {
                    if (x1 + x4 + x7 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button4.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x5 + x7 == -15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button7.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x7 + x8 + x9 == -15)
                    {
                        this.button7.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
                x8 = 5;
                button8.Text = "X";
                if (x2 + x5 + x8 == 15 || x7 + x8 + x9 == 15)
                {
                    if (x2 + x5 + x8 == 15)
                    {
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x7 + x8 + x9 == 15)
                    {
                        this.button7.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x8 = -5;
                button8.Text = "O";
                if (x2 + x5 + x8 == -15 || x7 + x8 + x9 == -15)
                {
                    if (x2 + x5 + x8 == -15)
                    {
                        this.button2.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x7 + x8 + x9 == -15)
                    {
                        this.button7.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            i++;
            if (i % 2 == 1)
            {
                x9 = 5;
                button9.Text = "X";
                if (x1 + x5 + x9 == 15 || x3 + x6 + x9 == 15 || x7 + x8 + x9 == 15)
                {
                    if (x1 + x5 + x9 == 15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x6 + x9 == 15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x7 + x8 + x9 == 15)
                    {
                        this.button7.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            else
            {
                x9 = -5;
                button9.Text = "O";
                if (x1 + x5 + x9 == -15 || x3 + x6 + x9 == -15 || x7 + x8 + x9 == -15)
                {
                    if (x1 + x5 + x9 == -15)
                    {
                        this.button1.BackColor = System.Drawing.Color.Red;
                        this.button5.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x3 + x6 + x9 == -15)
                    {
                        this.button3.BackColor = System.Drawing.Color.Red;
                        this.button6.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                    if (x7 + x8 + x9 == -15)
                    {
                        this.button7.BackColor = System.Drawing.Color.Red;
                        this.button8.BackColor = System.Drawing.Color.Red;
                        this.button9.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                    }
                }
            }
            button9.Enabled = false;
        }
        
        
    }
}
