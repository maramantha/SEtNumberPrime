using System;
using System.Collections.Generic;

namespace _10001st_prime
{
    class Program
    {
        static bool checkBy2(char[] inputVal)
        {
            
            return inputVal[inputVal.Length -1] % 2 == 0;
        }
        static bool checkBy3(char[] inputVal)
        {
            long sumCheckVal = 0;
            for(int i = 0; i < inputVal.Length;i++)
            {
                sumCheckVal += Convert.ToInt32(inputVal[i].ToString());
            }
            return sumCheckVal % 3 == 0;
        }
        static bool primeBrute(long inputVal)
        {
            if (5 > Math.Sqrt(inputVal))
            {
                return true;
            } else
            {
                for (int i = 5; i <= Math.Sqrt(inputVal); i += 2)
                {
                    if(inputVal % i ==0)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
        static bool primeFinder(long inputVal)
        {
            char[] checkVal = inputVal.ToString().ToCharArray();
            if(!checkBy2(checkVal))
            {
                if(!checkBy3(checkVal))
                {
                    return primeBrute(inputVal);
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            List<long> primeNum = new List<long>();
            primeNum.Add(2);
            primeNum.Add(3);
            int indexPrime = primeNum.Count;
            long CheckValue = 4;
            while (indexPrime <= 1000000)
            {
                if(primeFinder(CheckValue))
                {
                    primeNum.Add(CheckValue);
                }
                CheckValue++;
                indexPrime = primeNum.Count;
            }
            primeNum.Sort();
            Console.WriteLine(primeNum[indexPrime-1].ToString());
        }
    }
}
