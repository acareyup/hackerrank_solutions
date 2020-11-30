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
    static void staircase(int n) {

        for(int i=1; i <= n; i++)
        {   
            string s = "";
            //" " 
            for(int b = n-i; b > 0; b--)
            {
                s += " ";
            }
            for(int a = 0; a<i; a++)
            {
                s +="#";
            }
            Console.WriteLine(s);
        }
    }

    #endregion

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}