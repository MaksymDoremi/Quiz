using System.Collections.Generic;

namespace Quiz.Objects
{
    public class Question
    {
        private int id;
        private string questionText;
        private byte[] photo;

        private List<Answer> answerList;

        public Question(int id, string question, byte[] photoByteArray)
        {
            this.Id = id;
            this.QuestionText = question;
            this.Photo = photoByteArray;
            answerList = new List<Answer>();

        }

        public Question(string question, byte[] photoByteArray)
        {
            this.QuestionText = question;
            this.Photo = photoByteArray;
        }

        public int Id { get { return id; } set { id = value; } }
        public string QuestionText { get { return questionText; } set { questionText = value; } }
        public byte[] Photo { get { return photo; } set { photo = value; } }

        public List<Answer> AnswerList { get => answerList; set => answerList = value; }
        public void AddAnswerToAnswerList(Answer answer)
        {
            answerList.Add(answer);
        }

    }
}
