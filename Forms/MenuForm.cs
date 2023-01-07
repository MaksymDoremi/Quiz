using Quiz.Forms;
using Quiz.Objects;
using System;
using System.Windows.Forms;

namespace Quiz
{
    public partial class MenuForm : Form
    {
        private int countOfQuestions = 0;

        private BusinessLogicLayer bl;

        public BusinessLogicLayer Bl { get => bl; set => bl = value; }
        public int CountOfQuestions
        {
            get => countOfQuestions;
            set => countOfQuestions = value > 0 ? value : 0;

        }
        public MenuForm()
        {
            InitializeComponent();
        }

        private void startQuizBtn_Click(object sender, EventArgs e)
        {
            if (CountOfQuestions == 0)
            {
                MessageBox.Show("No questions in database. Contact developer.");
                return;
            }
            else
            {
                bl = new BusinessLogicLayer(CountOfQuestions);
                //send count of actual questions
                QuizForm form = new QuizForm(this, bl.PlayingDeckOfQuestions.Count, bl);
                form.Show();
                this.Hide();
            }

        }

        private void difficultyBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                CountOfQuestions = Int32.Parse(btn.Text);
                //Console.WriteLine(CountOfQuestions);
            }

        }

        private void openRedactorBtn_Click(object sender, EventArgs e)
        {
            RedactorForm form = new RedactorForm(this);
            form.Show();
            this.Hide();

        }
    }
}
