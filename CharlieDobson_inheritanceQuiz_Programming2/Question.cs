using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_inheritanceQuiz_Programming2
{
    internal class Question
    {
        protected string _questionText;
        protected string _answerText;

        public Question(string questionText, string answerText)
        {
            _questionText  = questionText;
            _answerText = answerText;
        }

        public void Ask()
        {
            Console.WriteLine(_questionText);
        }

        public virtual bool CheckAnswer()
        {
            Console.WriteLine("What is the answer?: ");
            string givenAnswer = Console.ReadLine();
            givenAnswer = givenAnswer.ToLower();

            if(givenAnswer.Trim() == _answerText.ToLower().Trim())
            {
                return true;
            }
            return false;
        }


    }
}
