namespace Quiz.Objects
{
    public class Answer
    {

        private int id;
        private string answerText;
        private bool correct;

        //used for remebmering my choice when going back or forth
        private bool chosen = false;

        public Answer(int id, string answerText, bool correct)
        {
            this.Id = id;
            this.AnswerText = answerText;
            this.Correct = correct;

        }

        public int Id { get { return id; } set => id = value > 0 ? value : 0; }
        public string AnswerText { get { return answerText; } set { answerText = value; } }
        public bool Correct { get { return correct; } set { correct = value; } }
        public bool Chosen { get => chosen; set => chosen = value; }
    }
}
