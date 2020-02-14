using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int turn = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //Takes the Button which was sent to the method as a generic object and casts it back to a Button. Makes it so only one event is necessary.
            if (button.Text == "Press To Select")
            {
                if (turn % 2 == 0)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
                WinCheck();
                turn++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WinCheck()
        {
            bool winState = false;
            //Horizontal Checks
            if (A0.Text == A1.Text && A1.Text == A2.Text && A0.Text != "Press To Select") winState = true;
            if (B0.Text == B1.Text && B1.Text == B2.Text && B0.Text != "Press To Select") winState = true;
            if (C0.Text == C1.Text && C1.Text == C2.Text && C0.Text != "Press To Select") winState = true;
            //Vertical Checks
            if (A0.Text == B0.Text && B0.Text == C0.Text && A0.Text != "Press To Select") winState = true;
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "Press To Select") winState = true;
            if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "Press To Select") winState = true;
            //Diagonal Checks
            if (A0.Text == B1.Text && B1.Text == C2.Text && A0.Text != "Press To Select") winState = true;
            if (A2.Text == B1.Text && B1.Text == C0.Text && A2.Text != "Press To Select") winState = true;


            if (winState == true)
            {
                if (turn % 2 == 0)
                {
                    string message = "Would you like to play again?";
                    string title = "X's have won the game!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        // reset
                        for (int i = 0; i < this.Controls.Count; i++)
                        {
                            foreach (Control control in Controls)
                            {
                                Button button = (Button)control;
                                A0.Text = "Press to select";
                                A1.Text = "Press to select";
                                A2.Text = "Press to select";
                                B0.Text = "Press to select";
                                B1.Text = "Press to select";
                                B2.Text = "Press to select";
                                C0.Text = "Press to select";
                                C1.Text = "Press to select";
                                C2.Text = "Press to select";
                            }
                            winState = false;
                        }
                    }
                }
                else
                {
                    string message = "Would you like to play again?";
                    string title = "O's have won the game!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        // reset
                        for (int i = 0; i < this.Controls.Count; i++)
                        {
                            foreach (Control control in Controls)
                            {
                                Button button = (Button)control;
                                A0.Text = "Press to select";
                                A1.Text = "Press to select";
                                A2.Text = "Press to select";
                                B0.Text = "Press to select";
                                B1.Text = "Press to select";
                                B2.Text = "Press to select";
                                C0.Text = "Press to select";
                                C1.Text = "Press to select";
                                C2.Text = "Press to select";
                            }
                            winState = false;
                        }

                    }
                }
               /** try
                {
                    foreach (Control control in Controls)
                    {
                        Button button = (Button)control;
                        button.Enabled = false; //Disables all buttons after a winner is declared. Need to set to true when starting new game.
                    }
                }
                catch { }  **/
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Darian Fisher, Jackson Foster, and Logan Jones", "About Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
