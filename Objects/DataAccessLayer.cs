using Quiz.DB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quiz.Objects
{
    public class DataAccessLayer
    {

        #region Add Items

        /// <summary>
        /// adds new question into database
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public bool AddQuestion(Question question)
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                //push the question to database
                using (SqlCommand cmd = new SqlCommand(Program.INSERT_QUESTION, db.connection))
                {
                    cmd.Parameters.AddWithValue("@question", question.QuestionText);
                    cmd.Parameters.AddWithValue("@photo", question.Photo);

                    cmd.ExecuteNonQuery();


                }

                db.connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        /// <summary>
        /// adds new answer to question with questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <param name="answer"></param>
        /// <param name="trueOrFalse"></param>
        /// <returns></returns>
        public bool AddAnswer(int questionID, string answer, bool trueOrFalse)
        {
            Answer ans = new Answer(questionID, answer, trueOrFalse);

            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                //push the answer into database with foreign key of questionId
                using (SqlCommand cmd = new SqlCommand(Program.INSERT_ANSWER, db.connection))
                {
                    cmd.Parameters.AddWithValue("@questionID", questionID);
                    cmd.Parameters.AddWithValue("@answer", answer);
                    cmd.Parameters.AddWithValue("@trueOrFalse", trueOrFalse);

                    cmd.ExecuteNonQuery();

                    db.connection.Close();
                }
                return true;
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
        /// Reads all questions from database and return new datatable
        /// </summary>
        /// <returns></returns>
        public DataTable ReadQuestions()
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            using (SqlDataAdapter sda = new SqlDataAdapter(Program.GET_QUESTIONS, db.connection))
            {
                DataTable dt = new DataTable();

                sda.Fill(dt);
                db.connection.Close();
                return dt;

            }


        }
        /// <summary>
        /// Reads all answers with questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public DataTable ReadAnswers(int questionID)
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State != ConnectionState.Closed)
            {
                db.connection.Open();
            }
            SqlCommand cmd = new SqlCommand(Program.GET_ANSWER, db.connection);
            cmd.Parameters.AddWithValue("@questionID", questionID);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                db.connection.Close();
                return dt;
            }


        }
        #endregion

        #region Delete Items
        /// <summary>
        /// Deletes one question where questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public bool DeleteQuestion(int questionID)
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(Program.DELETE_QUESTION, db.connection))
                {
                    cmd.Parameters.AddWithValue("@questionID", questionID);
                    cmd.ExecuteNonQuery();
                    db.connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Deletes all answers related to questionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public bool DeleteAllAnswers(int questionID)
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(Program.DELETE_ALL_ANSWERS, db.connection))
                {
                    cmd.Parameters.AddWithValue("@questionID", questionID);
                    cmd.ExecuteNonQuery();
                    db.connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Deletes answer where answerId
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        public bool DeleteAnswer(int answerId)
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(Program.DELETE_ANSWER, db.connection))
                {
                    cmd.Parameters.AddWithValue("@answerID", answerId);
                    cmd.ExecuteNonQuery();
                    db.connection.Close();
                }
                return true;
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
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(Program.UPDATE_QUESTION, db.connection))
                {
                    cmd.Parameters.AddWithValue("@questionID", questionInstance.Id);
                    cmd.Parameters.AddWithValue("@imageByte", questionInstance.Photo);
                    cmd.Parameters.AddWithValue("@question", questionInstance.QuestionText);
                    cmd.ExecuteNonQuery();
                    db.connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        /// <summary>
        /// Updates answer data where answerID
        /// </summary>
        /// <param name="answerInstance"></param>
        /// <returns></returns>
        public bool UpdateAnswer(Answer answerInstance)
        {
            DataBaseConnection db = new DataBaseConnection();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(Program.UPDATE_ANSWER, db.connection))
                {
                    cmd.Parameters.AddWithValue("@answer", answerInstance.AnswerText);
                    cmd.Parameters.AddWithValue("@trueOrFalse", answerInstance.Correct);
                    cmd.Parameters.AddWithValue("@answerID", answerInstance.Id);

                    cmd.ExecuteNonQuery();
                    db.connection.Close();
                }
                return true;
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
