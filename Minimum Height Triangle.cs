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
    public static int lowestTriangle(int trianglebase, int area)
    {
        return (int)Math.Ceiling((2.0 * area) / trianglebase);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int trianglebase = Convert.ToInt32(firstMultipleInput[0]);

        int area = Convert.ToInt32(firstMultipleInput[1]);

        int height = Result.lowestTriangle(trianglebase, area);

        textWriter.WriteLine(height);

        textWriter.Flush();
        textWriter.Close();
    }
}
