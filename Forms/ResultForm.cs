using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class ResultForm : Form
    {
        public ResultForm(double reached, int possible)
        {
            InitializeComponent();
            this.resultLabel.Text = "You have reached " + reached + " out of " + possible;
        }

        private void endQuizBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
