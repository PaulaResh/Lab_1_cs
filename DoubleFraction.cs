public class LB1
{
    public double Fraction(double x)//1_1
    {
        int y;
        y = Convert.ToInt32(x);
        return x - y;
    }

    public int charToNum(char x)//1_3
    {
        return x - '0';
    }
    public bool is2Digits(int x)//1_5
    {
        if (9 < x & x < 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isInRange(int a, int b, int num)//1_7
    {
        int max, min;
        max = Math.Max(a, b);
        min = Math.Min(a, b);
        if ((num <= max) && (num >= min))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool isEqual(int a, int b, int c)//1_9
    {
        return (a == b ) && (c == a);
    }

    public int abs(int x)//2_1
    {
        return Math.Abs(x);
    }
    public bool is35(int x)//2_3
    {
        if ((x % 3 == 0) & (x % 5 != 0))
        {
            return true;
        }
        else 
        {
            if ((x % 3 != 0) & (x % 5 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        } 
    }

    public int max3(int x, int y, int z)//2_5
    {
        if (y > x)
        {
            x = y;
        }

        if (z > x)
        {
            x = z;
        }

        return x;
    }
    public int sum2(int x, int y)//2_7
    {
        int summa;
        summa = x + y;
        if ((summa > 9) & (summa < 20))
        {
            return 20;
        }
        else
        {
            return summa;
        }
    }
    public String day(int x)//2_9
    {
        switch (x)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "это не день недели";
        }
    }
    public String reverseListNums(int x)//3_1
    {
        string[] nums = new string[x];
        int j = 0;
        for (int i = x; i > 0; i--)
        {
            nums[j] = i.ToString();
            j++;
        }
        return string.Join(" ", nums);
    }
    public String chet(int x)//3_3
    {
        string result = "";

        for (int i = 0; i <= x; i += 2)
        {
            result += i + " ";
        }

        return result;
    }   
    public int numLen(long x)//3_5
    {
        string number;
        number = x.ToString();
        return number.Length;
    }
    public void square(int x)//3_7
        {
            string line = "";

            for (int k = 0; k < x; k++)
            {
                line += "*";
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(line);
            }
        }
    public void rightTriangle(int x)//3_9
    {
        char c = '*', pr = ' ';
        x = Math.Abs(x);
        for (int i = 1; i < x+1; i++)
        {
            Console.WriteLine(new string(pr, (x - i)) + new string(c, (i)));
        }
    }
    public int findFirst(int[] arr, int x)//4_1
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }
    public int maxAbs(int[] arr)//4_3
    {
        int max_num = -1, max;
        for (int i = 0; i < arr.Length; i++)
        {
            max = Math.Abs(arr[i]);
            max_num = Math.Max(max, max_num);
        }
        return max_num;
    }

    public int[] add(int[] arr, int[] ins, int pos)//4_5
    {
        if (pos < 0)
        {
            pos = 0;
        }

        if (pos > arr.Length)
        {
            pos = arr.Length;
        }

        int[] result = new int[arr.Length + ins.Length];
        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }

        for (int i = 0; i < ins.Length; i++)
        {
            result[pos + i] = ins[i];
        }

        for (int i = pos; i < arr.Length; i++)
        {
            result[i + ins.Length] = arr[i];
        }

        return result;
    }
    public int[] reverseBack(int[] arr)//4_7
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
        return arr;
    }

    public int[] findAll(int[] arr, int x)//4_9
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }

        int[] result1 = new int[count];
        count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result1[count] = i;
                count++;
            }
        }

        return result1;
    }
}
