using Quiz.Controls;
using Quiz.Objects;
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
    public partial class RedactorForm : Form
    {
        private BusinessLogicLayer bl;
        private MenuForm menuForm;
        public RedactorForm(MenuForm form)
        {
            InitializeComponent();
            this.menuForm = form;

            InitQuestions();
        }

        /// <summary>
        /// Reads question from database and displays in question control
        /// </summary>
        private void InitQuestions()
        {
            this.flowLayout.Controls.Clear();
            //pull questions from database, fill Questions list
            bl = new BusinessLogicLayer();
            bl.GetAllQuestionsIntoList();

            if (bl.Questions.Count == 0)
            {
                MessageBox.Show("No qeustions in database. Contact developer.");
                return;
            }
            else
            {
                QuestionControl[] questions = new QuestionControl[bl.Questions.Count];

                for (int i = 0; i < questions.Length; i++)
                {
                    questions[i] = new QuestionControl(bl.Questions[i]);
                    //event handler to update question list after submitting changes
                    questions[i].submitChanges += new EventHandler(InitQuestionList);
                    this.flowLayout.Controls.Add(questions[i]);
                }
            }
        }
        /// <summary>
        /// Event handler method, just helps to execute InitQuestions()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitQuestionList(object sender, EventArgs e)
        {
            InitQuestions();
        }
        /// <summary>
        /// Goes back to menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }
        /// <summary>
        /// Opens AddQuestionForm where you add new question and submit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewQuestionBtn_Click(object sender, EventArgs e)
        {
            AddQuestionForm form = new AddQuestionForm();
            form.SubmitQuestionEventHandler += new EventHandler(InitQuestionList);
            form.ShowDialog();
        }
        /// <summary>
        /// Closes the main thread - menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedactorForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
