# HackerRank-Algo-Solutions
### In this repository you can find some of the hackerrank.com algo related problem solutions. Last i solved at top.


## [Repeated String](https://www.hackerrank.com/challenges/repeated-string/problem)
```c#
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
```

## [Counting Valleys](https://www.hackerrank.com/challenges/counting-valleys/problem)

```c#
int[] ones = new int[path.Length];
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i]=='U')
            {
                ones[i] = 1;
            }
            else
            {
                ones[i] = -1;
            }
        }

        int sum = 0;
        bool valley = false;
        int counter = 0;
        foreach (int item in ones)
        {
            sum += item;
            if (valley && sum==0)
            {
                counter++;
            }
            if (sum<0)
            {
                valley = true;
            }
            if (sum>=0)
            {
                valley = false;
            }
        }
        return counter;
```
## [Jumping on the Clouds](https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem)

```c#
static int jumpingOnClouds(int[] c)
    {
        int counter = 0;
        for (int i = 0; i < c.Length; i++)
        {
            if ((i + 2) < c.Length && c[i + 2] != 1)
            {
                counter++;
                i++;
            }
            else
            {
                counter++;
            }

        }
        return counter - 1;
    }
```

## [Sales by Match](https://www.hackerrank.com/challenges/sock-merchant/problem)

```c#
    int sockPair = 0;
    List<int> arList = new List<int>(ar);

    List<int> distList = ar.Distinct().ToList();

    foreach (int item in distList)
    {
        int temp = 0;
        foreach (int item2 in arList)
        {
            if (item==item2)
            {
                temp++;
            }
        }
        sockPair += temp / 2;
    }
    return sockPair;
```

## [Grading Students](https://www.hackerrank.com/challenges/grading/problem)

```c#
public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count(); i++)
        {
            if (grades[i]>37 && grades[i]%5>=3 && grades[i] % 5 != 0)
            {
                grades[i] += (5-grades[i]%5);
            }
        }
        return grades;
    }
```

## [Time Conversion](https://www.hackerrank.com/challenges/time-conversion/problem)

```c#
static string timeConversion(string s)
    {
        /*
         * Write your code here.
         */
        DateTime timeValue = Convert.ToDateTime(s);
        return timeValue.ToString("HH:mm:ss");

    }
```

## [Birthday Cake Candles](https://www.hackerrank.com/challenges/birthday-cake-candles/problem)

```c#
public static int birthdayCakeCandles(List<int> candles)
    {
        int x = candles.OrderByDescending(i=>i).FirstOrDefault();
        int count = 0;
        while (candles.Remove(x))
        {
            count++;
        }
        return count;
    }
```


## [Mini-Max Sum](https://www.hackerrank.com/challenges/mini-max-sum/problem)

```c#

static void miniMaxSum(int[] arr)
    {
        long[] longArr = new long[arr.Count()];
        for (int i = 0; i < 5; i++)
        {
            longArr[i] = arr[i];
        }
        Array.Sort(longArr);

        long max = longArr.Sum() - longArr[0];
        long min = longArr.Sum() - longArr[4];
        Console.WriteLine($"{min.ToString()} {max.ToString()}");
    }
```

## [Staircase](https://www.hackerrank.com/challenges/staircase/problem)

```c#
static void staircase(int n) {
        string text = "";
            string hash = "";
            for (int i = 0; i < n; i++)
            {
                text += ' ';
            }
            for (int i = 1; i < n+1; i++)
            {
                hash += '#';
                Console.WriteLine(text.Substring(i) + hash);
            }
    }
```

## [Plus Minus](https://www.hackerrank.com/challenges/plus-minus/problem)

```c#
static void plusMinus(int[] arr)
    {
        int p = 0;
        int n = 0;
        int z = 0;

        foreach (int item in arr)
        {
            if (item>0)
            {
                p++;
            }
            if (item==0)
            {
                z++;
            }
            if (item<0)
            {
                n++;
            }
        }
        decimal pD = Convert.ToDecimal(p) / Convert.ToDecimal(arr.Length);
        decimal nD = Convert.ToDecimal(n) / Convert.ToDecimal(arr.Length);
        decimal zD = Convert.ToDecimal(z) / Convert.ToDecimal(arr.Length);
        Console.WriteLine(pD.ToString());
        Console.WriteLine(nD.ToString());
        Console.WriteLine(zD.ToString());
    }
```

## [Diagonal Difference](https://www.hackerrank.com/challenges/diagonal-difference/problem)

```c#
public static int diagonalDifference(List<List<int>> arr)
    {
        int d1 = 0;
        int d2 = 0;
        int length = arr[0].Count;
        for (int i = 0; i < arr[0].Count; i++)
        {
            d1 += arr[i][i];
            d2 += arr[i][length - 1];
            length--;
        }
        return Math.Abs(d1 - d2);
    }
```