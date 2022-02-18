﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmMain : Form
    {

        bool turn = true; // true = X turn, false = O Turn

        int turnCount = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mine, 2022", "About");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Restart", "About");
            turn = true;
            turnCount = 0;

            
                foreach (Control c in Controls)
                {
                try
                    {
                       Button b = (Button)c;
                       b.Enabled = true;
                      b.Text = "";
                    }
                catch { }
                }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turnCount++;
            checkForWinner();
        }
        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                    there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                    there_is_a_winner = true;
            //horizontal checks

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!C3.Enabled))
                there_is_a_winner = true;
            //vertical checks

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B2.Enabled))
                there_is_a_winner = true;
            //diagonal checks 

            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = tbxP2.Text;
                    OWinCount.Text = (int.Parse(OWinCount.Text) + 1).ToString();  
                }

                else
                {
                    winner = tbxP1.Text;
                    XWinCount.Text = (int.Parse(XWinCount.Text) + 1).ToString();
                }
                    

                MessageBox.Show(winner + " Wins!", "Congrats!");
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw!", "Result");
                    DrawCount.Text = (int.Parse(DrawCount.Text) + 1).ToString();
                }
            }

        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    b.Text = "";

                }//end try
                catch { }
            }//end foreach

        }

        private void btnEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }//end if
            }
        }

        private void btnLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            { 
                    b.Text = "";
            }
        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OWinCount.Text = "0";
            DrawCount.Text = "0";
            XWinCount.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
