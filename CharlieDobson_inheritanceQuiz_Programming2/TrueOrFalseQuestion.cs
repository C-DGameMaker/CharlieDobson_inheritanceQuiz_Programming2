using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_inheritanceQuiz_Programming2
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string questionText, bool answerAsBool) : base ( questionText,  answerAsBool.ToString())
        {
            _questionText = questionText;
            _answerText = answerAsBool.ToString();
        }
    }
}
