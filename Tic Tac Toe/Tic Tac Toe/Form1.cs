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
        public Form1()
        {
            InitializeComponent();
            int turn = 0;
        }


        private void A0_Click(object sender, EventArgs e)
        {
            if (A0.Text == "Press To Select")
            {
                A0.Text = "X";
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (A1.Text == "Press To Select")
            {
                A1.Text = "X";
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (A2.Text == "Press To Select")
            {
                A2.Text = "X";
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (B0.Text == "Press To Select")
            {
                B0.Text = "X";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.Text == "Press To Select")
            {
                B1.Text = "X";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2.Text == "Press To Select")
            {
                B2.Text = "X";
            }
        }

        private void C0_Click(object sender, EventArgs e)
        {
            if (C0.Text == "Press To Select")
            {
                C0.Text = "X";
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (C1.Text == "Press To Select")
            {
                C1.Text = "X";
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (C2.Text == "Press To Select")
            {
                C2.Text = "X";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
