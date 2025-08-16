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
    public static List<string> solve(string s)
    {
        var result = new List<string>();
        var combinations = GetCombinations(s);
        result.AddRange(combinations.OrderBy(x => x));
        return result;
    }

    private static List<string> GetCombinations(string s)
    {
        var list = new List<string>();
        int n = s.Length;

        for (int i = 1; i <= n; i++)
        {
            var temp = GetCombinationsHelper(s, i);
            list.AddRange(temp);
        }

        return list;
    }

    private static List<string> GetCombinationsHelper(string s, int length)
    {
        var list = new List<string>();
        var chars = s.ToCharArray();
        Array.Sort(chars);
        s = new string(chars);

        GetCombinationsRec(s, length, 0, "", list);
        return list;
    }

    private static void GetCombinationsRec(string s, int length, int start, string current, List<string> list)
    {
        if (current.Length == length)
        {
            list.Add(current);
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            GetCombinationsRec(s, length, i + 1, current + s[i], list);
        }
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
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            List<string> result = Result.solve(s);

            textWriter.WriteLine(String.Join("\n", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
