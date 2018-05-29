using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        if (p<=n/2)
        {
            return p/2;
        }
        else if (p>n/2 && n%2 ==0 && p==n-1)
            return 1;
        else if(p>n/2 && n%2 ==0)
        {
            return (n-p)/2;
        }
        else
        {
            return (n-p)/2;
        }
            
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}