using System.Text.RegularExpressions;

namespace HaaardWork
{
    internal class Program
    {
        public static int[] FindCommonItem(int[] arr1, int[] arr2, int[] arr3)
        {
            int[] arr0 = { };
            int a = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    for (int k = 0; k < arr3.Length; k++)
                    {
                        if (arr3[k] == arr2[j])
                        {
                            if (arr3[k] == arr1[i])
                            {
                                Array.Resize(ref arr0, a + 1);
                                arr0[a] = arr3[k];
                                a++;
                            }
                        }
                    }
                }
            }
            int[] answer = arr0.Distinct().ToArray();
            return answer;
        }


        static void Main(string[] args)
        {
            //k개이 정렬된 배열에서 공통항목을 찾는 solution을 완성하라. 단 중복은 혀용하지 않는다.
            int[] a = { 4,5,6,2,1,6,7,35,53,91,69};
            int[] b = {35,7,7,9,90,123,35,45,74 };
            int[] c = {35,7,45,123,123456789 };
            int[] d = FindCommonItem(a, b, c);
            foreach(int i in d)
            {
                Console.WriteLine(i);
            }
            //7, 35
        }
    }
}