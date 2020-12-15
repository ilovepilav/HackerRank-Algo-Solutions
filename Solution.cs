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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        //int sLenght = s.Length;
        //long iter = n / sLenght;
        //long remain = n % sLenght;
        //int iterLenghtA = s.Length - s.Replace("a", "").Length;
        //string subS = s.Substring(0, Convert.ToInt32(remain));
        //int subSCount = subS.Length - subS.Replace("a", "").Length;

        //return iter * iterLenghtA + subSCount;


        // And this is the one-liner :)
        return (n / s.Length) * (s.Length - s.Replace("a", "").Length) + ((s.Substring(0, Convert.ToInt32(n % s.Length))).Length - (s.Substring(0, Convert.ToInt32(n % s.Length))).Replace("a", "").Length);
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
