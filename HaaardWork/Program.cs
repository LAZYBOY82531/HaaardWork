using System.Text.RegularExpressions;

namespace HaaardWork
{
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            bool answer = false;
            int b = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    b++;
                }
            }
            if (b == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }


        static void Main(string[] args)
        {
            //주어진 숫자가 소수인지 판별하는 solution을 완성하라
            int a = 17;
            int b = 4;
            Console.WriteLine(IsPrime(a));
            Console.WriteLine(IsPrime(b));
            //true, false
        }
    }
}