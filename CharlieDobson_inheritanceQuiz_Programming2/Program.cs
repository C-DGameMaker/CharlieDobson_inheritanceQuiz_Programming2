using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_inheritanceQuiz_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Question> _quizQuestions = new List<Question>();
            int _maxScore = _quizQuestions.Count;
            int _currentScore = 0;
            string _titleArt = " _      _____ _     ____ ____  _      _____   _____ ____    _     ___  _   ____  _      ____  ____  _  _      _____\r\n/ \\  /|/  __// \\   /   _Y  _ \\/ \\__/|/  __/  /__ __Y  _ \\  / \\__/|\\  \\//  /  _ \\/ \\__/|/  _ \\/_   \\/ \\/ \\  /|/  __/\r\n| |  |||  \\  | |   |  / | / \\|| |\\/|||  \\      / \\ | / \\|  | |\\/|| \\  /   | / \\|| |\\/||| / \\| /   /| || |\\ ||| |  _\r\n| |/\\|||  /_ | |_/\\|  \\_| \\_/|| |  |||  /_     | | | \\_/|  | |  || / /    | |-||| |  ||| |-||/   /_| || | \\||| |_//\r\n\\_/  \\|\\____\\\\____/\\____|____/\\_/  \\|\\____\\    \\_/ \\____/  \\_/  \\|/_/     \\_/ \\|\\_/  \\|\\_/ \\|\\____/\\_/\\_/  \\|\\____\\\r\n                                                                                                                   \r\n ____  _     _  ____    ____  ____  ____  _    _____                                                               \r\n/  _ \\/ \\ /\\/ \\/_   \\  /  _ \\/  _ \\/  _ \\/ \\ /Y__ __\\                                                              \r\n| / \\|| | ||| | /   /  | / \\|| | //| / \\|| | || / \\                                                                \r\n| \\_\\|| \\_/|| |/   /_  | |-||| |_\\\\| \\_/|| \\_/| | |                                                                \r\n\\____\\\\____/\\_/\\____/  \\_/ \\|\\____/\\____/\\____/ \\_/                                                                \r\n                                                                                                                   \r\n ____  _     ____  _____ ____    _      ____  ____  _  ____    _     ____  ____  _____                             \r\n/ ___\\/ \\ /\\/  __\\/  __//  __\\  / \\__/|/  _ \\/  __\\/ \\/  _ \\  / \\   /  _ \\/  __\\/  __/                             \r\n|    \\| | |||  \\/||  \\  |  \\/|  | |\\/||| / \\||  \\/|| || / \\|  | |   | / \\||  \\/||  \\                               \r\n\\___ || \\_/||  __/|  /_ |    /  | |  ||| |-|||    /| || \\_/|  | |_/\\| \\_/||    /|  /_                              \r\n\\____/\\____/\\_/   \\____\\\\_/\\_\\  \\_/  \\|\\_/ \\|\\_/\\_\\\\_/\\____/  \\____/\\____/\\_/\\_\\\\____\\                             \r\n                                                                                                                   ";

            Console.WriteLine(_titleArt);

            for(int i = 0; i < _quizQuestions.Count; i++)
            {
                Console.WriteLine($"{_currentScore}/{_maxScore}");
                Console.WriteLine(" ");

                _quizQuestions[i].Ask();
                _quizQuestions[i].CheckAnswer();

                if(_quizQuestions[i].CheckAnswer() == true)
                {
                    Console.WriteLine("You got it right!");
                    _currentScore++;
                }
                else
                {
                    Console.WriteLine("You got it wrong...");
                }

            }
        }
    }
}
