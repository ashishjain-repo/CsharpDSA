public class Program
{
    /* 
O(1) "Constant"
Assignment, Declaration, Arithmetic, Comparison, Accessing ELement, calling function all are constants
Something like this
 */
    public void someFunc(int num)
    {
        int number = num;
    }
    /* O(N) "Linear"
    Think "for loops", Number of inputs increase time, just take the big complexity or something like this: - 
    Something like this
    */
    public void linearComplexity(int number)
    {
        int total = number;
        int initial = 0;
        while(initial < total)
        {
            initial++;
        }
    }

/* 
O(N^2) "Quadratic"
Something like this: -
 */
public static void quadraticComplexity()
{
    int i = int.Parse(Console.ReadLine());
    for(int j = 1; j <= i; j++)
    {
        for(int k = 1; k <= i; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
    public static void Main(string[] args)
    {
        quadraticComplexity();
    }
}