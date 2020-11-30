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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        
       #region MYCODE
        
        long max, min, sum;
        sum = max = min = arr[0];

        for(int i=1; i<5;i++)
        {
            long temp = arr[i];
            
            sum += temp;
            
            if(max>temp)
            {
                if(min > temp) {
                    min = temp;
                }
            } 
            else 
            {
                max = temp;
            }
        }

        Console.Write((sum -max) + " " + (sum - min));
        #endregion

    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}