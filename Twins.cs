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
     * Complete the 'solve' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     */
    public static int solve(int n, int m)
    {
        if (m < 2 || m < n) return 0;

        int limit = (int)Math.Sqrt(m) + 1;
        List<int> basePrimes = SimpleSieve(limit);

        bool[] isPrime = new bool[m - n + 1];
        for (int i = 0; i < isPrime.Length; i++)
            isPrime[i] = true;

        if (n == 1) isPrime[0] = false;

        foreach (int p in basePrimes)
        {
            long start = Math.Max((long)p * p, ((n + p - 1L) / p) * p);
            for (long j = start; j <= m; j += p)
                isPrime[j - n] = false;
        }

        int count = 0;
        int prevPrime = -1;

        for (int i = 0; i < isPrime.Length; i++)
        {
            if (isPrime[i])
            {
                int current = n + i;
                if (prevPrime != -1 && current - prevPrime == 2)
                    count++;
                prevPrime = current;
            }
        }

        return count;
    }

    private static List<int> SimpleSieve(int limit)
    {
        bool[] mark = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
            mark[i] = true;

        for (int p = 2; p * p <= limit; p++)
        {
            if (mark[p])
            {
                for (int j = p * p; j <= limit; j += p)
                    mark[j] = false;
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
            if (mark[i]) primes.Add(i);

        return primes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.solve(n, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
