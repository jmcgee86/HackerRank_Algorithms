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

    // Complete the fairRations function below.
    static int fairRations(int[] B) {
        var loavesAdded = 0;
        for(var i =0; i<B.Length-1; i++)
        {
            if(B[i]%2 !=0)
            {
                B[i]+=1;
                B[i+1]+=1;
                loavesAdded+=2;
            }
        }
        if(B[B.Length-1]%2!=0)
        {
            return -1;
        }
        else
        {
        return loavesAdded;    
        }
        
        

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine());

        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
        ;
        int result = fairRations(B);
        
        if (result == -1)
        {
            textWriter.WriteLine("NO");
        }
        else
        {
            textWriter.WriteLine(result);
        }
        

        textWriter.Flush();
        textWriter.Close();
    }
}