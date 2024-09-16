using System;

namespace Problem_Solving.Easy;


class Result 
{
    string problem = "https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=false";

    public static void staircase(int n) 
    {
        // base x height  = n = 4

        for (int i = 0; i < n; i++)
        {

            for(int j = n; j < i; j++) 
            {
                Console.WriteLine("#");
            }
        }
    }
}

public class Staircase
{
    public static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}



