namespace Array_ArrayInsertions;
public class Program
{
    public static void Main(string[] args)
    {
        int[]  intArray = new int[10];
        int length = 0;
        for(int i = 0; i < 8; i++)
        {
            intArray[length] = i;
            length++;
        }
        // Insert at the end of array
        /* 
            intArray[length] = 9;
            length++; 
        */
        // Insert at the start of array
        /* 
            for(int i = length; i >= 0; i--)
            {
                intArray[i+1] = intArray[i];
            }
            intArray[0] = 20; 
        */
        // Insert anywhere in array
            for(int i = length; i >= 5; i--)
            {
                intArray[i + 1] = intArray[i];
            }
            intArray[5] = 8;
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }
        // Delete from the end of array

        // Delete from the start of array

        // Delete from anywhere in array

    }
}