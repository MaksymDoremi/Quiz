using System;
using System.Windows.Forms;
using Quiz.Forms;
using Quiz.Objects;

namespace Quiz.Controls
{
    public partial class QuestionControl : UserControl
    {
        private Question questionInstance;

        public event EventHandler submitChanges;
        public QuestionControl(Question question)
        {
            InitializeComponent();
            this.QuestionInstance = question;

            InitItems();
        }

        public Question QuestionInstance
        {
            get => questionInstance;
            set => questionInstance = value;
        }

        public void InitItems()
        {
            this.questionPhoto.Image = Program.ConvertByteArrayToImage(QuestionInstance.Photo);
            this.questionLabel.Text = QuestionInstance.QuestionText;
        }

        private void QuestionClicked(object sender, EventArgs e)
        {
            //opens dialog where you can update question
            QuestionForm form = new QuestionForm(QuestionInstance);
            form.SubmitChangesEventHandler += new EventHandler(SubmitChangesAndUpdateQuestionList);
            form.ShowDialog();
        }

        /// <summary>
        /// Help method to update questions after changing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SubmitChangesAndUpdateQuestionList(object sender, EventArgs e)
        {
            if (submitChanges != null)
            {
                this.submitChanges(sender, e);
            }
        }
    }
}
