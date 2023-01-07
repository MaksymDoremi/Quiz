using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Quiz
{
    internal static class Program
    {
        #region SQL Commands
        #region Add Items
        /// <summary>
        /// Insert new Question
        /// @question, @photo
        /// </summary>
        public const string INSERT_QUESTION = "insert into Question(Question, Photo) values(@question, @photo)";
        /// <summary>
        /// Insert answer for certain question
        /// @questionID, @answer, @trueOrFalse
        /// </summary>
        public const string INSERT_ANSWER = "insert into Answer(Question_ID, Answer, Correct) values(@questionID, @answer, @trueOrFalse)";
        #endregion
        #region Get Items
        /// <summary>
        /// Get all questions into DataTable.
        /// ID, Question, Photo(byte[])
        /// </summary>
        public const string GET_QUESTIONS = "select * from Question";
        /// <summary>
        /// Get answer and its truth. ID, Answer, Correct
        /// </summary>
        public const string GET_ANSWER = "select * from Answer where Answer.Question_ID = @questionID";
        #endregion
        #region Update Items
        /// <summary>
        /// set @question, set @imageByte, where @questionID
        /// </summary>
        public const string UPDATE_QUESTION = "update Question set Question = @question, Photo = @imageByte where ID = @questionID";
        /// <summary>
        /// set @answer, set @trueOrFalse, where @answerID
        /// </summary>
        public const string UPDATE_ANSWER = "update Answer set Answer =@answer, Correct = @trueOrFalse where ID = @answerID";
        #endregion
        #region Delete Items
        /// <summary>
        /// Deletes question, where @questionID
        /// </summary>
        public const string DELETE_QUESTION = "delete from Question where ID = @questionID";
        /// <summary>
        /// In case you want to delete whole question => delete all answers first
        /// @questionID
        /// </summary>
        public const string DELETE_ALL_ANSWERS = "delete from Answer where Question_ID = @questionID";
        /// <summary>
        /// Delete single answer, @answerID
        /// </summary>
        public const string DELETE_ANSWER = "delete from Answer where ID = @answerID";
        #endregion
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());

        }

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        //Copyright StackOverFlow
        //https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        //Copyright StackOverFlow
        //https://stackoverflow.com/questions/273313/randomize-a-listt
        public static void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
