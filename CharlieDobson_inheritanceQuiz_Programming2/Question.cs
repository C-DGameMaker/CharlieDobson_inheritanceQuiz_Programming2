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

        public Question(string _writtenQuestion, string _writtenAnswer)
        {
            _questionText  = _writtenQuestion;
            _answerText = _writtenAnswer;
        }

        public void Ask()
        {
            Console.WriteLine(_questionText);
        }

        public virtual bool CheckAnswer()
        {
            Console.WriteLine("What is the answer?: ");
            string _givenAnswer = Console.ReadLine();

            if(_givenAnswer == _answerText)
            {
                return true;
            }
            return false;
        }


    }
}
