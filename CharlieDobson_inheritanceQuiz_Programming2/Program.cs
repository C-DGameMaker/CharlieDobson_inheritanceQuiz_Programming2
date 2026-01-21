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
        static List<Question> _quizQuestions = new List<Question>()
        {

            new Question("Fact: There are many characters of many different names, What is the main character's name?", "Mario"),

            new MultipleChoiceQuestion("Fact: Bowser is usually the main adversary within the series, however, there are sometimes where he isn't. In which series does Mario actively team up with Bowser", new[] 
            {
                "the new Series", 
                "Mario and Luigi", 
                "Super Mario Brother Super show", 
                "The Adventure of Super Mario bros 3"
            }, 
            2),

            new TrueOrFalseQuestion("True or False? Mario has a brother", true),

            new Question("Fact: The Mario world is vast, with many different locations. What is the name of the main location where our hero lives?", "Mushroom Kingdom"),

            new MultipleChoiceQuestion("Fact: The paper mario series has a vast amount of partners, which one of these isn't an actual Partner?", new[] 
            {
                "ParaKarry, the postal Paratroopa",
                "Goombella, the helpful Goomba", 
                "Professor Toad, the archelogist toad",
                "Pear, the prickly Pokey"
            }, 
            4),

            new TrueOrFalseQuestion("True or False? Waluigi, Wario's friend and Luigi's rival, has his own spin off game.", false),

            new Question("Fact: Mario has faced off with many villians in his past, and in this classic gameboy game, he faces off against one known as Tataganda, what is the game's name", "Super Mario Land"),

            new MultipleChoiceQuestion("Fact: The western release of this Mario Game wasn't the orginal, which game was it?", new[] 
            {
                "SMB 2", 
                "SMB 3", 
                "Mario Party", 
                "Mario Golf"
            }, 
            1),

            new TrueOrFalseQuestion("True or False? Bowser has 8 children total <Not inculding Koopa Kid>.", true),
        };
        static void Main(string[] args)
        {
            int _maxScore = _quizQuestions.Count;
            int _currentScore = 0;
            string _titleArt = " _      _____ _     ____ ____  _      _____   _____ ____    _     ___  _   ____  _      ____  ____  _  _      _____\r\n/ \\  /|/  __// \\   /   _Y  _ \\/ \\__/|/  __/  /__ __Y  _ \\  / \\__/|\\  \\//  /  _ \\/ \\__/|/  _ \\/_   \\/ \\/ \\  /|/  __/\r\n| |  |||  \\  | |   |  / | / \\|| |\\/|||  \\      / \\ | / \\|  | |\\/|| \\  /   | / \\|| |\\/||| / \\| /   /| || |\\ ||| |  _\r\n| |/\\|||  /_ | |_/\\|  \\_| \\_/|| |  |||  /_     | | | \\_/|  | |  || / /    | |-||| |  ||| |-||/   /_| || | \\||| |_//\r\n\\_/  \\|\\____\\\\____/\\____|____/\\_/  \\|\\____\\    \\_/ \\____/  \\_/  \\|/_/     \\_/ \\|\\_/  \\|\\_/ \\|\\____/\\_/\\_/  \\|\\____\\\r\n                                                                                                                   \r\n ____  _     _  ____    ____  ____  ____  _    _____                                                               \r\n/  _ \\/ \\ /\\/ \\/_   \\  /  _ \\/  _ \\/  _ \\/ \\ /Y__ __\\                                                              \r\n| / \\|| | ||| | /   /  | / \\|| | //| / \\|| | || / \\                                                                \r\n| \\_\\|| \\_/|| |/   /_  | |-||| |_\\\\| \\_/|| \\_/| | |                                                                \r\n\\____\\\\____/\\_/\\____/  \\_/ \\|\\____/\\____/\\____/ \\_/                                                                \r\n                                                                                                                   \r\n ____  _     ____  _____ ____    _      ____  ____  _  ____    _     ____  ____  _____                             \r\n/ ___\\/ \\ /\\/  __\\/  __//  __\\  / \\__/|/  _ \\/  __\\/ \\/  _ \\  / \\   /  _ \\/  __\\/  __/                             \r\n|    \\| | |||  \\/||  \\  |  \\/|  | |\\/||| / \\||  \\/|| || / \\|  | |   | / \\||  \\/||  \\                               \r\n\\___ || \\_/||  __/|  /_ |    /  | |  ||| |-|||    /| || \\_/|  | |_/\\| \\_/||    /|  /_                              \r\n\\____/\\____/\\_/   \\____\\\\_/\\_\\  \\_/  \\|\\_/ \\|\\_/\\_\\\\_/\\____/  \\____/\\____/\\_/\\_\\\\____\\                             \r\n                                                                                                                   ";

            Console.WriteLine(_titleArt);
            Console.ReadKey(true);
            Console.Clear();

            for(int i = 0; i < _quizQuestions.Count; i++)
            {
                Console.WriteLine($"{_currentScore}/{_maxScore}");
                Console.WriteLine(" ");
                Console.WriteLine($"QUESTION {i+1}");

                _quizQuestions[i].Ask();

                if(_quizQuestions[i].CheckAnswer() == true)
                {
                    Console.WriteLine("You got it right!");
                    _currentScore++;
                }
                else
                {
                    Console.WriteLine("You got it wrong...");
                }

                Console.ReadKey(true);
                Console.Clear();

            }

            Console.WriteLine($"You got {_currentScore}/{_maxScore} right");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
