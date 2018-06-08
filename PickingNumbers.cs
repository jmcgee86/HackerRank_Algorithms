using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the pickingNumbers function below.
    static int pickingNumbers(int[] a) {
        var positiveTemp = 0;
        var negativeTemp = 0;
        var passes = 0;
    for (var  i= 0; i<a.Length; i++)
    {
        for (var j =0; j<a.Length; j++)
        {
            if(a[i]-a[j]==1 || a[i]-a[j]==0)
            {
                positiveTemp++;
            }
            else if(a[i]-a[j]==-1 || a[i]-a[j]==0)
            {
                negativeTemp++;
            }
        }
        if (positiveTemp>passes)
        {
            passes = positiveTemp;
        }
        else if(negativeTemp>passes)
        {
            passes = negativeTemp;
        }
        positiveTemp=0;
        negativeTemp = 0;
    }
return passes;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}