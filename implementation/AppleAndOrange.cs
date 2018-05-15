using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the countApplesAndOranges function below.
     */
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        var appleCount = 0;
        var orangeCount = 0;

        foreach (var apple in apples)
        {   
  
            if(apple + a <= t && apple + a >= s)
                appleCount++;
        }
        
        foreach(var orange in oranges)
        {
            if(orange<0 && b+orange>=s && b+orange<=t)
                orangeCount++;
        }
        
        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);
        
        int totalFruit = m+n;
        
        if (totalFruit == 0)
            throw new IndexOutOfRangeException("improper data input");

        int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
        ;

        int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
        ;
        countApplesAndOranges(s, t, a, b, apple, orange);
    }
}