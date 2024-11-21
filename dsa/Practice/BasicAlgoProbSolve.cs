public class BasicAlgoProbSolve
{
    public static string ReverseString(string word)
    {
        string newStr = "";
        for (int i = word.Length; i >= 1; i--)
        {
            newStr += word[i - 1];
        }
        return newStr;
    }
    public static int LargeElement(int[] data)
    {
        int temp = data[0];
        foreach (int element in data)
        {
            if (element > temp)
            {
                temp = element;
            }
        }
        return temp;
    }
    public static int NumOccurence(int[] data, int number)
    {
        int occur = 0;
        foreach (int element in data)
        {
            if (element == number)
            {
                occur++;
            }
        }
        return occur;
    }
    public static int MissingNumber(int[] data)
    {
        int num = 0;
        for (int i = 1; i < data.Length; i++)
        {
            if (data.Contains(i))
            {
                num += 1;
            }
            else
            {
                break;
            }
        }
        return num + 1;
    }
    public static bool PalindromeCheck(string sentence)
    {
        string temp = ReverseString(sentence);
        if (sentence == temp)
        {
            return true;
        }
        return false;
    }
    public static int[] SumOfTwo(int[] data, int target)
    {
        int[] sum = new int[2];
        int index1 = 0;
        foreach (int element in data)
        {
            int index2 = 0;
            foreach (int num in data)
            {
                if ((element + num) == target)
                {
                    sum[0] = index1;
                    sum[1] = index2;
                    break;
                }
                index2++;
            }
            index1++;
        }
        return sum;
    }
    public static int SecondLargest(int[] data)
    {
        int largest = data[0];
        int secondLargest = data[0];
        foreach (int num in data)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if(num < largest && num > secondLargest)
            {
                secondLargest = num;
            }
        }
        return secondLargest;
    }
    public static int[] ReverseArray(int[] data)
    {
        Stack<int> newArray = new Stack<int>();
        foreach(int i in data)
        {
            newArray.Push(i);
        }
        int[] reversedArray = new int[data.Length];
        for(int i = 0; i < data.Length; i++)
        {
            reversedArray[i] = newArray.Pop();
        }
        return reversedArray;
    }
}