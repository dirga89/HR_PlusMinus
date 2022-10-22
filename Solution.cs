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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int arrLength = arr.Count;
        int plusCount = 0, minusCount = 0, zeroCount = 0;
        
        double plusResult, minusResult, zeroResult;
        
        //Console.WriteLine(arrLength);
        //Console.WriteLine(arr[0].ToString());
        for(int i=0; i<arrLength ; i++)
        {
            if(arr[i]>0)
                plusCount++;
            else if (arr[i]<0)
                minusCount++;
            else
                zeroCount++;
        }
        
        plusResult = (double)plusCount/arrLength;
        minusResult = (double)minusCount/arrLength;
        zeroResult = (double)zeroCount/arrLength;
        
        Console.WriteLine(plusResult.ToString("0.000000"));
        Console.WriteLine(minusResult.ToString("0.000000"));
        Console.WriteLine(zeroResult.ToString("0.000000"));
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //int n = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(n.ToString());
        Console.WriteLine("Masukkan angka boleh plus, minus, nol. Antar angka dipisahkan oleh spasi: ");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
