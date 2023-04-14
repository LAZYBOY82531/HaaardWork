namespace HaaardWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a와 b의 값 찾기
            int a = 32 >> 1;
            int b = a >> 3;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}