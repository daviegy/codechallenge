using System;
using System.Collections.Generic;

namespace codechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ar =new List<int>() { 1,2,1,2,1,3,2 };
            int result = sockMerchant(ar.Count, ar);
            Console.WriteLine($"result: {result}");
        }
        /// <summary>
        /// return numbers of pair that exist in an array and ignore the odds
        /// ex: List<int> ar =new List<int>() { 1,2,1,2,1,3,2 };
        ///     int result = sockMerchant(ar.Count, ar);
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int sockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            int pair = 0;
            for (int i = 0; i < n;i++)
            {
                if (i < n - 1) {
                    if (ar[i] == ar[i + 1])
                    {
                        pair++;
                        i +=1;
                    }
                }
               
                
            }
            return pair;
        }
    }

    
}
