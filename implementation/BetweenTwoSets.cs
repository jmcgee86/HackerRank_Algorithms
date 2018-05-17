using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
        var count = 0;
        var divisible = 0;
        var between = new List<int>();
       for (var i = a.Max(); i<=b.Min(); i++ )
       {
           divisible = 0;
           foreach (var num in a)
               if(i%num ==0)
                   divisible++;
                if (divisible == a.Length)
                {
                    between.Add(i);
                    divisible = 0;
                }
       }

        for(var j=0; j<between.Count; j++)
        {
            divisible = 0;
            foreach (var num in b)
            {
                if(num%between[j] ==0)
                {
                    divisible++;
                }
                if (divisible == b.Length)
                {
                    count++;
                    divisible = 0;
                }    
            }
        }
        return count;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);
        
        if(n==0 || m ==0)
            throw new InvalidOperationException("must enter parameters correctly");

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}