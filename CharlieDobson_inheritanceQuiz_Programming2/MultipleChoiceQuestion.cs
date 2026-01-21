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

        public MultipleChoiceQuestion(string _writtenQuestion, string _writtenAnswer, int _rightAnswer): base( _writtenQuestion,  _writtenAnswer)
        {
            _questionText = _writtenQuestion;
            _correctAnswer = _rightAnswer;
        }

        public override bool CheckAnswer()
        {
            return base.CheckAnswer();
        }
    }
}
