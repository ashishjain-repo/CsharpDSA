class Program
{
    public static void Main(string[] args)
    {
        int grade = 48;
        string passStatus = grade < 50 ? "Failed" : "Passed";
        Console.WriteLine(passStatus);
    }
}