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

        public MultipleChoiceQuestion(string questionText, string[] answerText, int rightAnswer): base(questionText, answerText[rightAnswer-1])
        {
            _questionText = questionText;
            _correctAnswer = rightAnswer;
            _answerOptions = answerText;
        }

        public override bool CheckAnswer()
        {
            for(int i = 0; i < _answerOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {_answerOptions[1]}");
            }
            Console.WriteLine("Press the corrosponding number key to select your answer: ");
            char selectedAnswer;

            while(true)
            {
                selectedAnswer = Console.ReadKey().KeyChar;
                if(char.IsDigit(selectedAnswer))
                {
                    break;
                }
            }

            
            int answerAsInt = int.Parse(selectedAnswer.ToString());

            if(answerAsInt == _correctAnswer)
            {
                return true;
            }
            return false;
        }
    }
}
