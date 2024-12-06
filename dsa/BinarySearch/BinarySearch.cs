public class BinarySearch
{
    public int[] Arr {get; set;}
    public int Value {get; set;}
    public BinarySearch(int[] array, int val)
    {
        Arr = array;
        Value = val;
    }
    public int Search()
    {
        int start = 0;
        int end = Arr.Length;
        while(start < end)
        {
            int midpoint = (start + end) / 2;

            if(Arr[midpoint] == Value)
            {
                return midpoint;
            }
            else if(Arr[midpoint] < Value)
            {
                start = midpoint + 1;
            }
            else
            {
                end = midpoint;
            }
        }
        return -1;
    }
}