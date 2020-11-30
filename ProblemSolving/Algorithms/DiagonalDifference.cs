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

   #region MYCODE

    public static int diagonalDifference(List<List<int>> arr)
    {
        List<int> diagonal = new List<int>();
        List<int> xDiagonal = new List<int>();
        
        //calculate diagonal values
        for (int i=0; i<arr[0].Count; i++)
        {
            diagonal.Add(arr[i][i]);
        }
        //calculate xDiagonal
        for (int i = 0; i<arr[0].Count; i++)
        {
            xDiagonal.Add(arr[i][arr[0].Count-1-i]);
        }
        
        return Math.Abs(diagonal.Sum()-xDiagonal.Sum());
    }

    #endregion

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}