using Quiz.Objects;
using System;
using System.IO;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class AddQuestionForm : Form
    {
        /// <summary>
        /// Even handler that is used to update list of questions
        /// </summary>
        public event EventHandler SubmitQuestionEventHandler;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lists through pc storage
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
                    // questionInstance.Photo = File.ReadAllBytes(imageLocation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Invalidate();
        }
        /// <summary>
        /// Pushes new question to database and updates question list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {

            if (this.questionImage.Image == null)
            {
                MessageBox.Show("Image can't be empty");
                return;
            }

            if (this.questionTextBox.Text == "" || this.questionTextBox.Text == null)
            {
                MessageBox.Show("Question can't be empty");
                return;
            }

            try
            {
                BusinessLogicLayer bl = new BusinessLogicLayer();

                bl.AddQuestion(new Question(this.questionTextBox.Text, File.ReadAllBytes(this.questionImage.ImageLocation)));

                if (SubmitQuestionEventHandler != null)
                {
                    SubmitQuestionEventHandler(this, e);
                }
                MessageBox.Show("Question successfully added.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
