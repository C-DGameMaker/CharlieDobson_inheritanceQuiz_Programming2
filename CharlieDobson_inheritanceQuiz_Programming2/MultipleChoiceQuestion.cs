using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_inheritanceQuiz_Programming2
{
    internal class MultipleChoiceQuestion : Question
    {
        private string[] _answerOptions;
        private int _correctAnswer;

        public MultipleChoiceQuestion(string questionText, string answerText, int rightAnswer): base(questionText, answerText)
        {
            _questionText = questionText;
            _correctAnswer = rightAnswer;

            //_answerOptions = ;
        }

        public override bool CheckAnswer()
        {
            Console.WriteLine("Press the corrosponding number key to select your answer: ");

            return base.CheckAnswer();
        }
    }
}
