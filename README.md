# HackerRank-Algo-Solutions
### In this repository you can find some of the hackerrank.com algo related problem solutions which i solved.

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
