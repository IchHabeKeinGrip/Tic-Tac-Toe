using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (p1.Text != "" && p2.Text != "")
            {
                Form1.setPlayerNames(p1.Text, p2.Text);
                this.Close();
            }
            else
                MessageBox.Show("Please fill out both fields!", "Error!");
        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                btPlay.PerformClick();
        }

        private void p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                p2.Focus();
        }
    }
}
