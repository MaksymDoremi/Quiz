using Quiz.Objects;
using System;
using System.Windows.Forms;

namespace Quiz.Controls
{
    public partial class RedactorAnswer : UserControl
    {
        private Answer answer;

        /// <summary>
        /// Event handler that updates answer list immediately
        /// </summary>
        public event EventHandler AnswerDeleted;

        public RedactorAnswer(Answer answer)
        {
            InitializeComponent();
            this.answer = answer;

            InitItems();

        }

        private void InitItems()
        {
            this.correctCheckBox.Checked = answer.Correct ? true : false;
            this.answerTextBox.Text = answer.AnswerText;
            Invalidate();
        }

        public int GetAnswerId()
        {
            return answer.Id;
        }
        public string GetAnswerText()
        {
            return this.answerTextBox.Text;
        }
        public bool GetCorrect()
        {
            return this.correctCheckBox.Checked;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //create business layer instance to delete the actual record from databse
            BusinessLogicLayer bl = new BusinessLogicLayer();
            bl.DeleteAnswer(answer.Id);


            //call the event to upadte answer list
            if (this.AnswerDeleted != null)
            {
                this.AnswerDeleted(this, e);
            }
        }
    }
}
