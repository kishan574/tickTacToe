using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tickTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;


        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text == "") { 
            if(player%2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }

            else
            {
                button.Text = "O";
                player++;
                turns++;
            }

                if (CheckDraw() == true)
                {
                    sd++;
                    MessageBox.Show("Tie!");
                    NewGame();
                }

                if(Winner() == true)
                {
                    if(button.Text == "X")
                    {
                        MessageBox.Show("X wins");
                        s1++;
                        NewGame();
                    }

                    if (button.Text == "O")
                    {
                        MessageBox.Show("O wins");
                        s2++;
                        NewGame();
                    }
                }
                
           }
        }

        void LabelUpdate()
        {
            xwin.Text = "X:" + s1;
            owin.Text = "O:" + s2;
            draw.Text = "draw:" + sd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            LabelUpdate();
        }


        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool CheckDraw(){
            if (turns == 9 && Winner() == false)
                return true;
            else
                return false;
        }

        bool Winner()
        {
            //Horizantal
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;

            //vertical
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;

            //diagonal
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A21.Text) && (A02.Text != ""))
                return true;

            else
            return false;


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}

