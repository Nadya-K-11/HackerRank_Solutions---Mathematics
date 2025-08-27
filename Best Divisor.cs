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

class Solution
{
    public static int GetDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        int maxDigitSum = -1;
        int BestDivisor = -1;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                int currentSum = GetDigitSum(i);

                if (currentSum > maxDigitSum || (currentSum == maxDigitSum && i < BestDivisor))
                {
                    maxDigitSum = currentSum;
                    BestDivisor = i;
                }
            }
        }

        Console.WriteLine(BestDivisor);
    }
}
        Console.WriteLine(divisor);
    }
}
