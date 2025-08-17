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
    public static long strangeGrid(long r, long c)
    {
        long baseRow = (r - 1) / 2 * 10;
        if (r % 2 == 1)
            return baseRow + (c - 1) * 2;
        else
            return baseRow + (c - 1) * 2 + 1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        long r = Convert.ToInt64(firstMultipleInput[0]);
        long c = Convert.ToInt64(firstMultipleInput[1]);

        long result = Result.strangeGrid(r, c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
