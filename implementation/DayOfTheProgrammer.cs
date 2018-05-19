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

    // Complete the solve function below.
    static string solve(int year) {
        var reg = "13.09.";
        var leap = "12.09.";
        var switchYear = "26.09.";
        var inputYear = year.ToString();
        var output = "";
        if(year == 1918)
            output = switchYear + inputYear;
        else if (year<1918)
        {
            if(year%4==0)
                output = leap+inputYear;
            else
                output = reg+inputYear;
        }
            
        else if (year>1918)
        {
            if(year%400==0)
                output = leap+inputYear;
            else if(year%4==0 && year%100!=0)
                output = leap+inputYear;
            else
                output = reg+inputYear;

        }
        return output;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine());

        string result = solve(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}