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
    public static int solve(int n, List<int> coins)
    {
        int a = coins[0], b = coins[1], c = coins[2], d = coins[3];
        int[] values = { 1, 2, 5, 10 };
        int[] limits = { a, b, c, d };

        int[,] dp = new int[n + 1, 4];
        for (int i = 0; i <= n; i++)
            for (int j = 0; j < 4; j++)
                dp[i, j] = -1;

        Func<int, int, int> dfs = null;
        dfs = (sum, idx) =>
        {
            if (sum == 0) return 1;
            if (idx >= 4) return 0;
            if (dp[sum, idx] != -1) return dp[sum, idx];

            int res = 0;
            for (int k = 0; k <= limits[idx] && k * values[idx] <= sum; k++)
            {
                res += dfs(sum - k * values[idx], idx + 1);
            }

            dp[sum, idx] = res;
            return res;
        };

        return dfs(n, 0);
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

            List<int> coins = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(coinsTemp => Convert.ToInt32(coinsTemp)).ToList();

            int result = Result.solve(n, coins);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
