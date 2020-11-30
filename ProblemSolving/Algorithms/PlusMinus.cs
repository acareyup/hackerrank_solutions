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

    #region MYCODE
    static void plusMinus(int[] arr) {
        
        decimal length = arr.Length;
        
        decimal pos = Math.Round(arr.ToList().Where(x => x > 0).Count() / length, 6);
        
        decimal neg =  Math.Round (arr.ToList().Where(x => x < 0).Count()/length, 6);
        
        decimal zero =  Math.Round(arr.ToList().Where(x => x == 0).Count()/length, 6);
        
        Console.WriteLine(String.Format("{0:0.000000}", pos));
        
        Console.WriteLine(String.Format("{0:0.000000}", neg));
        
        Console.WriteLine(String.Format("{0:0.000000}", zero));
        
        #endregion

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}