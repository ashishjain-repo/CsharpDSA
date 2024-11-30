public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[] {1,2,3,4,5,6,7};
        bool LinearSearch(int[] array, int key)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }
        Console.WriteLine(LinearSearch(array, 7));
    }
}