// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;

namespace Program
{
    public class Program()
    {
        private int[] SolveProblem(int[] arr, int[,] queries)
        {
            int[] answer = new int[queries.GetLength(0)] ;

            int startNum = 0;
            int endNum = 0;
            int compareNum = 0;
            List<int> test = new List<int>();
    


            for (int i = 0; i < queries.GetLength(0); ++i)
            {
                startNum = queries[i, 0];
                endNum = queries[i, 1];
                compareNum = queries[i, 2];

                int result = -1;
                for (int j = startNum; j <= endNum; ++j)
                {
                    if (arr[j] > compareNum && result == -1)
                        result = arr[j];
                    if (result > arr[j])
                        result = arr[j];
                }
                answer[i] = result;

            }

            return answer;
        }


        public int[] soluTemp(int[] arr) 
        {
            List<int> stk = new List<int>();
       

            for (int i =0; i < arr.Length;) 
            {

                if (stk.Count <= 0) stk.Add(arr[i++]);

                if (arr[i] > stk[stk.Count - 1]) stk.Add(arr[i++]);
                else stk.RemoveAt(stk.Count - 1);

            }

            return stk.ToArray();
        }

        public static void Main(string[] _args)
        {
            Program test = new Program();
            int[] temp = new int[] { 5, 3, 4, 1, 2 };

            temp = test.soluTemp(temp);

            foreach (int i in temp) 
            {
                Console.Write($"{i}");
            }

        }
    }




}