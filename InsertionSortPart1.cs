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

    // Complete the insertionSort1 function below.
    static void insertionSort1(int n, int[] arr) {
        var temp = arr[n-1];
        for(var i=n-1; i>0; i--)
        {
            var printString = String.Empty;
            if(temp<arr[i-1])
            {
                arr[i]=arr[i-1];
                foreach(var number in arr)
                {
                    printString+= number + " ";
                }
                Console.WriteLine(printString);
                
            }
            else
            {
                arr[i] = temp;
                foreach(var number in arr)
                {
                    printString+= number + " ";
                }
                Console.WriteLine(printString);
                break;
            }
            
        }
            if(temp<arr[0])
            {
                arr[0] = temp;
                var printString = String.Empty;
            foreach(var number in arr)
                {
                 printString+= number + " ";
                }
                Console.WriteLine(printString);
            }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort1(n, arr);
    }
}