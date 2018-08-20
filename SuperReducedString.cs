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

    // Complete the superReducedString function below.
    static string superReducedString(string s) {
        if(s.Length==0)
            return "Empty String";
        if (s.Length == 1)
            return s;
        for(var i = 1; i<s.Length; i++)
            {
                if(s[i]==s[i-1])
                {
                    Console.WriteLine("remove at: " + i);
                    return superReducedString(s.Remove(i-1,2));
                }
            }            
        return s;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}