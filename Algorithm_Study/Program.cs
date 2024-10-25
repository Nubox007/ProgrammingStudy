using System;
using System.Collections.Generic;

namespace Program 

{

    public class Program
    {
           
        public static void Main(string[] _args)
        {

            string input = Console.ReadLine();

            if (input == null) return;

            string[] inputs = input.Split(' ');


            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            for (int i = 1; i < c; ++i) 
            {
                a = (a * 10) % b;
                
            }
            Console.WriteLine(a);

        }
    }
    public class Solution
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;
            List<int> scoreList = score.ToList();
            scoreList.Sort();

            for (int i = 0; i < scoreList.Count;)
            {
                answer += scoreList[i] * m;
                if (i >= scoreList.Count) break;
                else i += 2;
            }

            score.or


            return answer;
        }
    }



}