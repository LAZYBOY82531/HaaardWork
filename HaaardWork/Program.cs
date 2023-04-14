using System.Text.RegularExpressions;

namespace HaaardWork
{
    internal class Program
    {
        public static int SumOfDigits(int num)
        {
            int answer = 0;
            while (true)
            {
                answer += num % 10;
                num /= 10;
                if (num <= 0)
                {
                    break;
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            //주어진 숫자의 양의 정수의 각 자리수의 합을 구하는 solution을 완성하라
            int a = 1521344589;
            Console.WriteLine(SumOfDigits(a));
            //42
        }
    }
}