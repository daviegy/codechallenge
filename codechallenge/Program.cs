using System;
using System.Collections.Generic;
using System.Linq;

namespace codechallenge
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string s = "aba";
            long n = 10;
            long result = repeatedString(s, n);

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
        public static int SockMerchant(int n, List<int> ar)
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
        public static int CountingValleys(int steps, string path)
        {
            char[] ar = path.ToCharArray();            
            int valley = 0; //number of valler traversed
            int stepDir = 0;// direction of movement
            for (int i = 0; i < steps; i++)
            {
                if (ar[i] == 'D') // step direction will be downward
                    stepDir--;
                if(ar[i] == 'U') // step direction will be upward
                {
                    if (stepDir == -1) 
                        valley++;
                    stepDir++;
                }
                    
            }
            return valley;
        }
        public static int JumpingOnClouds(List<int> c)
        {
            int minJump = 0;
            int length = c.Count;
            int i = 0;

            while (i < length)
            {
                if (c[i] == 0) 
                {
                    if (i + 2 < length && c[i + 2] == 0)
                 {
                        i += 2;
                        minJump++;
                    }
                    else if (i + 1 < length && c[i + 1] == 0)
                    {
                        i += 1;
                        minJump++;
                    }
                    else
                        i++;

                }
            }
            return minJump;//
        }

        public static long repeatedString(string s, long n)
        {
            long number_of_a = 0;
            long sLength = s.Length;

            if (!s.Contains("a"))
                return number_of_a;

            if(sLength==1)
            {
                if (s == "a")
                    return n;
                else
                    return number_of_a;
            }

            long divisionResult =(long) Math.Floor((decimal)( n / sLength));
            long remainder = n % sLength;
            char[] sCharArray = s.ToCharArray();
            number_of_a = sCharArray.Where(x => x == 'a').Count();
            number_of_a *= divisionResult;
            if (remainder != 0)
            {
                for (int i = 0; i < remainder; i++)
                {
                    if (sCharArray[i] == 'a')
                        number_of_a++;
                }
            }

            return number_of_a;
        }
    }

    
}
