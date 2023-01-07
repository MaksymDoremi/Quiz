using Quiz.Objects;
using System;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class AddAnswerForm : Form
    {
        private int questionId;
        private BusinessLogicLayer bl;

        public AddAnswerForm(int questionId)
        {
            InitializeComponent();
            bl = new BusinessLogicLayer();
            this.questionId = questionId;
        }

        /// <summary>
        /// Submits and pushes answer to databse and links with questionnID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            bl.AddAnswer(questionId, this.answerTextBox.Text, this.correctCheckBox.Checked);
            this.Close();
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
