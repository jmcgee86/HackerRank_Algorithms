using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
   
    static string timeConversion(string s) {
        string beginning = "";
        int start = 0;
        if(s.Contains('A'))
        {
           start =  Int32.Parse(s.Remove(2));
            if(start<12)
                return s.Remove(8);
            else
            {
                s = s.Remove(0,2);
                s = s.Remove(6);
                start -=12;
                beginning = start.ToString();
                return "0"+beginning+s;
            }
        }
         else
         {    
            start = Int32.Parse(s.Remove(2));
            if(start<12)
                start +=12;
            s = s.Remove(0,2);
            s = s.Remove(6);
            beginning = start.ToString();
            return beginning+s;
         }

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}