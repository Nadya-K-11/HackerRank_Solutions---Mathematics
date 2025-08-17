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
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER a
     *  2. INTEGER b
     *  3. INTEGER c
     */
    static int Gcd(int x, int y) => y == 0 ? x : Gcd(y, x % y);

    public static string solve(int a, int b, int c)
    {
        if (c > Math.Max(a, b)) return "NO";
        return (c % Gcd(a, b) == 0) ? "YES" : "NO";

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(firstMultipleInput[0]);

            int b = Convert.ToInt32(firstMultipleInput[1]);

            int c = Convert.ToInt32(firstMultipleInput[2]);

            string result = Result.solve(a, b, c);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
