using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {
        #region MYCODE

        List<int> all_numbers = new List<int>();
        
        List<int> numbers = new List<int>();
        List<int> primes = new List<int>();
        
        int max_n = 105000;
        
        for(int i = 0; i < max_n; i++)
        {
            all_numbers.Add(i);
        }
        
        for(int i = 0; i < max_n; i++)
        {
            numbers.Add(0);
        }
        numbers.Add(-1); //for last element

        for (int i = 2; i < Math.Sqrt(max_n)+1; i++)
        {
            if(numbers[i] == 0)
            {
                for (int j = 2; j < max_n / i + 1; j++)
                {
                    numbers[i * j] = 1;
                }
            }
        }
        
        for(int i = 2; i<numbers.Count; i++)
        {
            if(numbers[i] == 0)
                primes.Add(i);
        }


        #endregion
        
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(primes[n-1]);
        }
    }
}
