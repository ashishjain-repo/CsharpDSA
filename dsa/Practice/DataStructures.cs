class ArrayManipulation
{
    public static int[] RotateArray(int[] data, int rotation)
    {
        List<int> newData = new List<int>(data);
        for (int i = 0; i < rotation; i++)
        {
            int temp = newData[0];
            newData.RemoveAt(0);
            newData.Add(temp);
        }
        int[] finalArray = new int[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            finalArray[i] = newData[i];
        }
        return finalArray;
    }
    public static int[] MergeArray(int[] arr1, int[] arr2)
    {
        int[] sortedList = new int[arr1.Length + arr2.Length];
        int arr1Length = arr1.Length;
        int arr2Length = arr2.Length;
        int index1 = 0;
        int index2 = 0;
        int sortedIndex = 0;
        while (index1 < arr1Length && index2 < arr2Length)
        {
            if (arr1[index1] <= arr2[index2])
            {
                sortedList[sortedIndex] = arr1[index1];
                index1++;
            }
            else
            {
                sortedList[sortedIndex] = arr2[index2];
                index2++;
            }
            sortedIndex++;
        }
        while (index1 < arr1Length)
        {
            sortedList[sortedIndex] = arr1[index1];
            index1++;
            sortedIndex++;
        }
        while (index2 < arr2Length)
        {
            sortedList[sortedIndex] = arr2[index2];
            index2++;
            sortedIndex++;
        }
        return sortedList;
    }
}

class LinkedList
{
    
}