using System.Text.RegularExpressions;

namespace HaaardWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            Random random = new Random();
            int answer = random.Next(0, 999);
            Console.WriteLine("업다운 게임 시작합니다! ");
            Console.WriteLine("10번안에 맞추셔야 합니다.");

            while (true)
            {
                count--;
                Console.WriteLine("\n정답을 맞춰주세요 : ");
                int useranswer = int.Parse(Console.ReadLine());
                CompareAnswer(answer, useranswer);
                if (GameSet(answer, useranswer, count))
                {
                    if (AskUser(ref count, ref answer, random))
                    {
                        break;
                    }
                }
                Console.WriteLine("\n{0}회 남았습니다. ", count);
            }
        }
        static void CompareAnswer(int answer, int useranswer)
        {
            if (answer == useranswer)
            {
                Console.WriteLine("정답입니다!");
            }
            else if (answer > useranswer)
            {
                Console.WriteLine("보다 큽습니다.");
            }
            else { Console.WriteLine("보다 작습니다."); }
        }
        static bool GameSet(int answer, int useranswer, int count)
        {
            if (answer == useranswer)
            {
                return true;
            }
            else if (count == 0)
            {
                return true;
            }
            return false;
        }
        static bool AskUser(ref int count, ref int answer, Random random)
        {
            Console.WriteLine("\n\n실패하셨습니다. \n다시 시작하기를 윈하시면 F를 눌러주세요.");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F)
            {
                count = 10;
                answer = random.Next(0, 999);
                return false;
            }
            return true;
        }
    }
}