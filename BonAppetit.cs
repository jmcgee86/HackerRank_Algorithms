using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static string paidResult(int []n, int[] ar, int paid) {
        var skippedIndex = (n[1]);
        var correctPayment = 0;
        
        for(var i = 0; i<ar.Length; i++)
        {
            correctPayment += ar[i];
        }
        
        correctPayment = (correctPayment - ar[skippedIndex])/2;
    
    if (correctPayment == paid)
    {
        return "Bon Appetit";
    }
    else
    {

        return (paid-correctPayment).ToString();
    }
    } 
    
    static void Main(string[] args) {
       TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int [] n = Array.ConvertAll(Console.ReadLine().Split(' '), tempAr => Convert.ToInt32(tempAr));

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        
        int paid = Convert.ToInt32(Console.ReadLine());
        
    var  result = paidResult(n, ar, paid);

 textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
      }
}
}