using Quiz.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Objects;
using Quiz.Controls;
using Quiz.Forms;

namespace Quiz
{
    public partial class QuizForm : Form
    {
        //instance for closing issues, nothing more
        private MenuForm menuForm;

        //count of questions to load
        private int countOfQuestions;

        private int index = 0;
        private int possibleCorrectAnswers = 0;
        private double reachedCorrectAnswers = 0;

        private BusinessLogicLayer bl;
        public QuizForm(Form menuForm, int countOfQuestions, BusinessLogicLayer bl)
        {
            InitializeComponent();
            this.menuForm = (MenuForm)menuForm;
            this.countOfQuestions = countOfQuestions;
            this.bl = bl;

            possibleCorrectAnswers = bl.PossibleCorrectAnswers();

            DisplayQuestion(bl.PlayingDeckOfQuestions[index]);

            this.questionIndexLabel.Text = (index + 1) + "/" + (countOfQuestions);
        }

        /// <summary>
        /// Displays answers into flowlayout from answerList
        /// </summary>
        /// <param name="question"></param>
        public void DisplayQuestion(Question question)
        {
            //clear before adding
            this.flowLayoutAnswers.Controls.Clear();

            //display question
            this.questionLabel.Text = question.QuestionText;
            //display photo
            this.pictureBox.Image = Program.ConvertByteArrayToImage(question.Photo);
            //display answers
            AnswerControl[] answerList = new AnswerControl[question.AnswerList.Count];

            for (int i = 0; i < answerList.Length; i++)
            {
                answerList[i] = new AnswerControl(question.AnswerList[i], this);
                this.flowLayoutAnswers.Controls.Add(answerList[i]);
            }
        }
        /// <summary>
        /// Adds points to the reached points
        /// </summary>
        /// <param name="answer"></param>
        public void SelectAnswer(Answer answer)
        {
            reachedCorrectAnswers += answer.Correct ? 1 : -0.25;
        }
        /// <summary>
        /// Removes points from reached points
        /// </summary>
        /// <param name="answer"></param>
        public void DeselectAnswer(Answer answer)
        {
            reachedCorrectAnswers -= answer.Correct ? 1 : -0.25;
        }

        private void QuizForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Loads next question from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (index + 1 < countOfQuestions)
            {
                index++;
                if (index == countOfQuestions - 1)
                {
                    this.submitQuizBtn.Visible = true;
                    this.nextBtn.Visible = false;
                }
                DisplayQuestion(bl.PlayingDeckOfQuestions[index]);
                Invalidate();

                this.questionIndexLabel.Text = (index + 1) + "/" + (countOfQuestions);
            }



        }
        /// <summary>
        /// Loads previous question from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (index - 1 > -1)
            {
                if (index == countOfQuestions - 1)
                {
                    this.submitQuizBtn.Visible = false;
                    this.nextBtn.Visible = true;
                }

                index--;
                DisplayQuestion(bl.PlayingDeckOfQuestions[index]);
                Invalidate();
                this.questionIndexLabel.Text = (index + 1) + "/" + (countOfQuestions);
            }


        }
        /// <summary>
        /// Opens result form and just displays result of the quiz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitQuizBtn_Click(object sender, EventArgs e)
        {
            ResultForm form = new ResultForm(this.reachedCorrectAnswers, this.possibleCorrectAnswers);
            form.Show();
            this.Hide();
        }
        /// <summary>
        /// Exits quiz and returns to menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }
    }
}
