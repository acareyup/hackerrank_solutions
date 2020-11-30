using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

   #region MYCODE
    static string timeConversion(string s) {
        string PMorAM = s.Substring(s.Length - 2,2);
        string tm = s.Substring(0, 8);
        string hh = s.Substring(0,2);
        string devam = tm.Substring(2,6);
        
        if(hh == "12" && PMorAM == "PM")
            return tm;
        if(hh == "12" && PMorAM =="AM")
            return "00"+devam;
            
        if(tm == "12:00:00" && PMorAM == "AM")
            return "00:00:00";
            
        int intHH = int.Parse(hh);
        
        if(PMorAM == "PM")
            intHH += 12;
        
        if(intHH == 24)
            return "00" + devam;
            
        if(intHH < 10)
            return "0"+intHH+devam;
        
        string sol = intHH + devam;
        
        return sol;
    }

    #endregion

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}