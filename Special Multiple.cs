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
    public static string solve(int n)
    {
        if (n == 1) return "9";
        int[] parent = new int[n];
        char[] dig = new char[n];
        bool[] vis = new bool[n];
        Queue<int> q = new Queue<int>();
        int r = 9 % n;
        if (r == 0) return "9";
        vis[r] = true;
        parent[r] = -1;
        dig[r] = '9';
        q.Enqueue(r);
        while (q.Count > 0)
        {
            int cur = q.Dequeue();
            int r0 = (cur * 10) % n;
            if (!vis[r0])
            {
                vis[r0] = true;
                parent[r0] = cur;
                dig[r0] = '0';
                if (r0 == 0) break;
                q.Enqueue(r0);
            }
            int r9 = (cur * 10 + 9) % n;
            if (!vis[r9])
            {
                vis[r9] = true;
                parent[r9] = cur;
                dig[r9] = '9';
                if (r9 == 0) break;
                q.Enqueue(r9);
            }
        }
        StringBuilder sb = new StringBuilder();
        int x = 0;
        while (x != -1)
        {
            sb.Append(dig[x]);
            x = parent[x];
        }
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
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

            string result = Result.solve(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
