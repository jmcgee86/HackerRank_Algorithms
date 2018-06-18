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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr) {
        var totalCuts = new List<int>();
        var removed=0;
 

        while(removed!=arr.Length)
        {
            var cut = arr.Max();
            var cuts=0;
            foreach (var stick in arr)
            {
                if (stick<cut && stick>0)
                    cut = stick;
                if (stick>0)
                    cuts++;
            }
            for (var i=0; i<arr.Length; i++)
            {
                arr[i]-=cut;
                if(arr[i]==0)
                    removed++;
            }

            totalCuts.Add(cuts);
 
        }
        return totalCuts.ToArray();
    }
    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}