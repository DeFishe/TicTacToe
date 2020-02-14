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
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        List<Button>buttons;
        Random rand = new Random();
        int playerWins = 0;
        int computerWins = 0;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender; //Takes the Button which was sent to the method as a generic object and casts it back to a Button. Makes it so only one event is necessary.
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Cyan;
            buttons.Remove(button);
            WinCheck();
            AImoves.Start();
          
        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon;
                buttons.RemoveAt(index);
                WinCheck();
                AImoves.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void buttonLoad()
        {
            buttons = new List<Button> { A0, A1, A2, B0, B1, B2, C0, C1, C2 };
        }


        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag =="play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "?";
                }
            }
            buttonLoad();
        }


        private void WinCheck()
        {
            if (A0.Text == "X" &&  A1.Text =="X" && A2.Text == "X"
                ||B0.Text == "X" && B1.Text =="X" && B2.Text == "X"
                ||C0.Text == "X" && C1.Text == "X" && C2.Text == "X"
                ||A0.Text == "X" && B0.Text =="X" && C0.Text == "X" 
                ||A1.Text == "X" && B1.Text =="X" && C1.Text == "X" 
                ||A2.Text == "X" && B2.Text =="X" && C2.Text == "X" 
                ||A0.Text == "X" && B1.Text =="X" && C2.Text == "X"  
                ||A2.Text == "X" && B1.Text =="X" && C0.Text == "X")
            {
                AImoves.Stop();
                MessageBox.Show("Player X Wins");
                resetGame();
            }
            else if (A0.Text == "O" && A1.Text == "O" && A2.Text == "O"
                || B0.Text == "O" && B1.Text == "O" && B2.Text == "O"
                || C0.Text == "O" && C1.Text == "O" && C2.Text == "O"
                || A0.Text == "O" && B0.Text == "O" && C0.Text == "O"
                || A1.Text == "O" && B1.Text == "O" && C1.Text == "O"
                || A2.Text == "O" && B2.Text == "O" && C2.Text == "O"
                || A0.Text == "O" && B1.Text == "O" && C2.Text == "O"
                || A2.Text == "O" && B1.Text == "O" && C0.Text == "O")
            {
                AImoves.Stop();
                MessageBox.Show("Player O Wins");
                resetGame();
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
    }
}
