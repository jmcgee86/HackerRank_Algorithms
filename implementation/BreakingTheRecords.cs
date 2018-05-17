using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the breakingRecords function below.
     */
    static int[] breakingRecords(int[] score) {
        var maxScore = score[0];
        var minScore = score[0];
        var max = 0;
        var min = 0;
        int [] results = new int[2];
        
        for(var i = 1; i<score.Length; i++)
        {
            if(score[i]>maxScore)
            {
                max++;
                maxScore = score[i];
            }
            if(score[i]<minScore)
            {
                min++;
                minScore = score[i];
            }    
        }
        
        results[0] = max;
        results[1] = min;
        return results;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
        ;
        int[] result = breakingRecords(score);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}