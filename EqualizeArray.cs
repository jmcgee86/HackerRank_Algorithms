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

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr) {
        var finalCount = 0;
         var tempCount = 0;
        foreach (var num in arr)
        {
            foreach (var n in arr)
            {
                if (num == n)
                    tempCount++;
            }
            if (tempCount > finalCount)
            {
                finalCount = tempCount;
            }
            tempCount = 0;
        }
return arr.Length - finalCount;
    }

    
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}