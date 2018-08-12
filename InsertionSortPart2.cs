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

    // Complete the insertionSort2 function below.
    static void insertionSort2(int n, int[] arr) {
        for(var i=1; i<n; i++)
        {
            var numberToInsert = arr[i];
            var positionToInsert = i;
            var printString = String.Empty;
            while(positionToInsert>0 && arr[positionToInsert-1] > numberToInsert)
            {
                arr[positionToInsert] = arr[positionToInsert-1];
                positionToInsert = positionToInsert-1;
            }
            arr[positionToInsert] = numberToInsert;
            foreach(var number in arr)
            {
               printString+=number + " "; 
            }
            Console.WriteLine(printString);
        }


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort2(n, arr);
    }
}