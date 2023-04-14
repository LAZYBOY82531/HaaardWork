using System.Text.RegularExpressions;

namespace HaaardWork
{
    internal class Program
    {
        public static int WordCheck(string String)
        {
            MatchCollection matches = Regex.Matches(String, " ");  //구글링

            int answer = matches.Count + 1;
            return answer;
        }

        static void Main(string[] args)
        {
            //문자열을 입력받으면 단어의 갯수를 출력하기
            Console.WriteLine(WordCheck("안녕하세요. 나는 시흥시에 사는 라스라고 합니다."));
            //6
        }
    }
}