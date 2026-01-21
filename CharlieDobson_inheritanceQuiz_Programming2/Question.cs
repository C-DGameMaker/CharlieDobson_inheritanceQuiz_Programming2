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

        public Question()
        {
            _questionText;
            _answerText;
        }

        public void Ask()
        {
            Console.WriteLine(_questionText);
        }


    }
}
