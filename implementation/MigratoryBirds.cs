using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    // Complete the migratoryBirds function below.
    static int migratoryBirds(int[] ar) {
        int [] type = new int [6];
        var result=0;
                
        foreach (var num in ar)
        {    if (num ==1)
                type[1]+=1;
            if (num ==2)
                type[2]+=1;
            if (num==3)
                type[3]+=1;
            if (num ==4)
                type[4]+=1;
            if (num==5)
                type[5]+=1;
        }
        for(var i = 1;i<type.Length; i++)
        {
            if(type[i]>type[result])
                result = i; 
        }   
        
        return result;
        
    

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = migratoryBirds(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}