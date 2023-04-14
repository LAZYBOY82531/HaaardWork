namespace HaaardWork
{
    internal class Program
    {
        class MyClass
        {
            public int a;
            public int b;
        }
        static void Main(string[] args)
        {
            //다음과 같은 코드가 있다고 가정할 때 출력결과와 그 이유를 서술하라
            MyClass source = new MyClass();
            source.a = 10;
            source.b = 20;

            MyClass target = source;
            target.b = 100;

            Console.WriteLine("{0}, {1}", source.a, source.b); 
            Console.WriteLine("{0}, {1}", target.a, target.b);
            //10 100
            //10 100
        }
    }
}