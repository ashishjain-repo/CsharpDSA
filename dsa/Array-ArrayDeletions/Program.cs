public class Program
{
    public static void Main(string[] args)
    {
        int[] intArray = new int[9];
        int length = 0;

        for(int i = 1; i < 8; i++)
        {
            intArray[length] = i;
            length++;
        }
        // Deleting From the end of Array
        /* length--;
         */

    // Deleting from the start of array
    /* for(int i = 0; i < length; i++)
    {
        intArray[i] = intArray[i + 1];
    };
    length--; */

// Deleting anywhere from an array

for(int i = 4; i < length; i++)
{
    intArray[i] = intArray[i + 1];
}
length--;
    for(int i = 0; i < length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
    }
}