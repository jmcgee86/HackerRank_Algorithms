using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int[] s, int d, int m){
            // Complete this function
        var count = 0;
        for(var i=0; i<n; i++)
        {
            var sum = 0;
            for (var j = 0; j<m; j++)
            {   
                if (i+j>=s.Length)
                    break;
                sum+= s[i+j];
            }
            if (sum == d)
                count++;
            
        }
        
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}