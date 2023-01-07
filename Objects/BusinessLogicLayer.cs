using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Quiz.Objects
{
    public class BusinessLogicLayer
    {
        //used for game and are randomly shuffled, taken from questions list
        private List<Question> playingDeckOfQuestions;

        //used for gathering all questions from db
        private List<Question> questions;

        public BusinessLogicLayer(int countOfQuestions)
        {
            Questions = new List<Question>();
            PlayingDeckOfQuestions = new List<Question>();

            InitPlayingListOfQuestions(countOfQuestions);
        }
        public BusinessLogicLayer()
        {
            Questions = new List<Question>();
        }
        public List<Question> PlayingDeckOfQuestions
        {
            get { return playingDeckOfQuestions; }
            set { playingDeckOfQuestions = value; }
        }
        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        #region Help Methods
        /// <summary>
        /// Initializes questions that are going to be used in the quiz
        /// </summary>
        /// <param name="count"></param>
        public void InitPlayingListOfQuestions(int count)
        {
            //gather all questions from database
            GetAllQuestionsIntoList();

            //throw error if not enough questions for the quiz
            //and continue with less count
            if (questions.Count < count)
            {
                MessageBox.Show("Not enough questions in database. Contact developer.");
                count = questions.Count;
            }

            //shuffle questions
            Program.Shuffle(questions);

            //count is defined from menu form - count of questions
            //so it will take only count of questions into my playing list
            for (int i = 0; i < count; i++)
            {
                playingDeckOfQuestions.Add(questions[i]);
            }

            //finally shuffle the result so make it even more shuffled
            Program.Shuffle(playingDeckOfQuestions);

        }

        /// <summary>
        /// Counts all correct answers that are possible to get and returns it
        /// </summary>
        /// <returns></returns>
        public int PossibleCorrectAnswers()
        {
            int result = 0;
            foreach (Question q in PlayingDeckOfQuestions)
            {
                foreach (Answer a in q.AnswerList)
                {
                    //if answer is correct then add 1
                    result += a.Correct ? 1 : 0;
                }
            }

            return result;
        }
        #endregion

        #region Add Items
        /// <summary>
        /// adds new question into database
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public bool AddQuestion(Question question)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.AddQuestion(question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// adds answer for question where questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <param name="answer"></param>
        /// <param name="trueOrFalse"></param>
        /// <returns></returns>
        public bool AddAnswer(int questionID, string answer, bool trueOrFalse)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.AddAnswer(questionID, answer, trueOrFalse);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Get Items
        /// <summary>
        /// Gets all questions into one list
        /// </summary>
        public void GetAllQuestionsIntoList()
        {
            DataTable dt = GetQuestions();

            if (dt == null)
            {
                MessageBox.Show("Database is empty");
                return;
            }

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                //add question
                questions.Add(new Question((int)row["ID"], (string)row["Question"], (byte[])row["Photo"]));

                //add answers to questions
                //gets answers by Question_ID foreign key
                DataTable answers = GetAnswers(questions[i].Id);

                foreach (DataRow answerRow in answers.Rows)
                {
                    questions[i].AddAnswerToAnswerList(new Answer((int)answerRow["ID"], (string)answerRow["Answer"], (bool)answerRow["Correct"]));

                }

                i++;
            }

        }

        /// <summary>
        /// Reads all questions from database
        /// </summary>
        /// <param name="index">Index in List of questions</param>
        /// <returns></returns>
        public DataTable GetQuestions()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.ReadQuestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Gets answers by questionID
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DataTable GetAnswers(int questionID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.ReadAnswers(questionID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }
        #endregion

        #region Delete Items
        /// <summary>
        /// Deletes whole question
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public bool DeleteQuestion(int questionID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.DeleteQuestion(questionID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Deletes all answers related to particular questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public bool DeleteAllAnswers(int questionID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.DeleteAllAnswers(questionID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Deletes only one answer with answerID
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        public bool DeleteAnswer(int answerId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.DeleteAnswer(answerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        #region Update Items
        /// <summary>
        /// Updates question data where questionID
        /// </summary>
        /// <param name="questionInstance"></param>
        /// <returns></returns>
        public bool UpdateQuestion(Question questionInstance)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.UpdateQuestion(questionInstance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Updates answer data with answerID
        /// </summary>
        /// <param name="answerInstance"></param>
        /// <returns></returns>
        public bool UpdateAnswer(Answer answerInstance)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.UpdateAnswer(answerInstance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
    }
}
