public class Program
{
    public static void Main(string[] args)
    {
        // To do Binary Search the data has to be sorted

        /* 
        What this algorithm do
        1. Find the middle element
        2. Is the middle element? Yes? Done.
        3. Is it bigger? Search the left half.
        4. Is it smaller? Search the right half
        5. Keep "Halfing" till you find the number
         */

        int[] MyArray = {-22,-2,2,11,14,74,83,111,578,564};
        int Value = 111;
        BinarySearch binarySearch = new BinarySearch(MyArray, Value);
        int result = binarySearch.Search();
        System.Console.WriteLine(result);
    }
}