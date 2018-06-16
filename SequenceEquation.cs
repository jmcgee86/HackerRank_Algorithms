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

    // Complete the permutationEquation function below.
    static int[] permutationEquation(int[] p) {
        int[]results = new int[p.Length];
        int[]original = (int[]) p.Clone();
        Array.Sort(p);
        var counter = 0;
        foreach (var x in p)
        {
            var indexX = Array.IndexOf(original, x)+1;
            var y = Array.IndexOf(original, indexX)+1;
            results[counter] = y;
            counter++;
        }
return results;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = permutationEquation(p);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}