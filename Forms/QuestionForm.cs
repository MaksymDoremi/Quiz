using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Quiz.Controls;
using Quiz.Objects;

namespace Quiz.Forms
{
    public partial class QuestionForm : Form
    {
        private Question questionInstance;
        private List<RedactorAnswer> answerControls;

        /// <summary>
        /// Event that updates question list with updates
        /// </summary>
        public event EventHandler SubmitChangesEventHandler;

        public QuestionForm(Question question)
        {
            InitializeComponent();
            this.questionInstance = question;

            InitItems();
        }
        private void InitItems()
        {
            this.questionImage.Image = Program.ConvertByteArrayToImage(questionInstance.Photo);
            this.questionTextBox.Text = questionInstance.QuestionText;

            InitAnswers();
            Invalidate();
        }

        /// <summary>
        /// Initializes answer controls aka buttons
        /// </summary>
        private void InitAnswers()
        {
            flowLayoutAnswers.Controls.Clear();

            answerControls = new List<RedactorAnswer>();

            for (int i = 0; i < questionInstance.AnswerList.Count; i++)
            {
                answerControls.Add(new RedactorAnswer(questionInstance.AnswerList[i]));
                this.flowLayoutAnswers.Controls.Add(answerControls[i]);
                answerControls[i].AnswerDeleted += new EventHandler(InitAnswerList);
            }
        }

        /// <summary>
        /// Lists through pc memory and looks for photos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listImagesBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    this.questionImage.ImageLocation = imageLocation;
                    questionInstance.Photo = File.ReadAllBytes(imageLocation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Invalidate();
        }

        /// <summary>
        /// Pushes question text and bytes of photo to database where ID=questionID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLayer bl = new BusinessLogicLayer();
                questionInstance.QuestionText = this.questionTextBox.Text;
                questionInstance.Photo = Program.ImageToByteArray(this.questionImage.Image);
                //update question
                bl.UpdateQuestion(questionInstance);

                //update answers


                foreach (RedactorAnswer a in answerControls)
                {
                    Answer answerInstance = new Answer(a.GetAnswerId(), a.GetAnswerText(), a.GetCorrect());
                    bl.UpdateAnswer(answerInstance);
                }

                MessageBox.Show("Changes applied");


                if (SubmitChangesEventHandler != null)
                {
                    this.SubmitChangesEventHandler(this, e);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Adds answer to answerList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAnswerBtn_Click(object sender, EventArgs e)
        {
            AddAnswerForm form = new AddAnswerForm(questionInstance.Id);
            //after close we need to load answer list again and update answer controls to see it
            form.FormClosed += InitAnswerList;
            form.ShowDialog();
        }

        /// <summary>
        /// Initialize answer list again with new data from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitAnswerList(object sender, EventArgs e)
        {
            //init answer list again
            this.questionInstance.AnswerList = GetAnswers(questionInstance.Id);
            //then init controls
            InitAnswers();

        }

        /// <summary>
        /// Gets all answers from database related to questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns>New list with updated answers</returns>
        private List<Answer> GetAnswers(int questionID)
        {
            List<Answer> answerList = new List<Answer>();
            //business layer instance to access methods
            BusinessLogicLayer bl = new BusinessLogicLayer();

            DataTable answers = bl.GetAnswers(questionID);

            if (answers == null) return null;

            foreach (DataRow answerRow in answers.Rows)
            {
                answerList.Add(new Answer((int)answerRow["ID"], (string)answerRow["Answer"], (bool)answerRow["Correct"]));
            }
            return answerList;
        }

        /// <summary>
        /// Deletes firsly all answers with questionID then the whole question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteWholeQuestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLayer bl = new BusinessLogicLayer();

                bl.DeleteAllAnswers(this.questionInstance.Id);
                bl.DeleteQuestion(this.questionInstance.Id);
                MessageBox.Show("Question Deleted");
                if (SubmitChangesEventHandler != null)
                {
                    this.SubmitChangesEventHandler(this, e);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
