using Quiz.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz.Controls
{
    public partial class AnswerControl : UserControl
    {
        private Answer answerInstance;
        //instance to use methods
        private QuizForm quizForm;
        public AnswerControl(Answer answer, QuizForm quizForm)
        {
            InitializeComponent();

            this.AnswerInstance = answer;
            this.quizForm = quizForm;

            InitAnswer();

        }

        private void InitAnswer()
        {
            this.answerLabel.Text = AnswerInstance.AnswerText;

            if (AnswerInstance.Chosen)
            {
                this.panel1.BackColor = Color.Gray;
            }
        }

        public Answer AnswerInstance { get => answerInstance; set => answerInstance = value; }

        private void ChooseAnswer(object sender, EventArgs e)
        {
            //make it grey 
            if (!AnswerInstance.Chosen)
            {
                this.panel1.BackColor = Color.Gray;
                AnswerInstance.Chosen = true;
                quizForm.SelectAnswer(AnswerInstance);
            }
            //or get back to default color
            else
            {
                this.panel1.BackColor = System.Drawing.SystemColors.Control;
                AnswerInstance.Chosen = false;
                quizForm.DeselectAnswer(AnswerInstance);
            }
        }

    }
}
