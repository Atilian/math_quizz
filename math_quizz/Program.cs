

using static System.Formats.Asn1.AsnWriter;

namespace math_quizz
{

    class Program
    {

        static void Main(string[] args)
        {
            game(1, 10, 5);
        }

        static void game(int rangeOne, int rangeTwo, int numberQuestion)
        {
            List<string> operators = new List<string>() {"+", "-", "/", "x" };

            var score = 0;

            var numQuestion = numberQuestion;

            while (numberQuestion > 0)
            {
                decimal numberOne = new Random().Next(rangeOne, rangeTwo);
                decimal numbertwo = new Random().Next(rangeOne, rangeTwo);

                var opera = operators[new Random().Next(0, operators.Count())];

                decimal answer;
                decimal answerUser;

                switch (opera)
                {
                    case "x":
                        answer = numberOne * numbertwo;
                        break;
                    case "/":
                        answer = decimal.Round((numberOne / numbertwo), 2);
                        break;
                    case "+":
                        answer = numberOne + numbertwo;
                        break;
                    case "-":
                        answer = numberOne - numbertwo;
                        break;
                    default:
                        answer = 0;
                        break;
                }


                while (true)
                {
                    Console.WriteLine("Question {0}\n", numQuestion - numberQuestion + 1);

                    Console.Write("->  {0} {1} {2} : ", numberOne, opera, numbertwo);

                    if (decimal.TryParse(Console.ReadLine(), out answerUser)) 
                    { 
                        break; 
                    }
                    else 
                    { 
                        Console.WriteLine("Erreur write a number");
                        Console.ReadLine();
                    }
                }
                

                if (answerUser == answer)
                {
                    score += 1;
                    Console.Write("Right");
                }
                else
                {
                    Console.Write("Answer : {0}\n", answer);
                }

                Console.ReadLine();

                Console.Clear();

                numberQuestion--;
            }

            Console.WriteLine("Your score is : {0}/{1}", score, numQuestion);
        }

    }

}