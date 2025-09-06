namespace DSAPlayground.Common;

public static class Fibonacci
{
    public static void FibonacciFor(int length)
    {
        int prev2 = 0;
        int prev1 = 1;
        int current;

        Console.WriteLine(prev2);
        Console.WriteLine(prev1);

        for (int i = 0; i < length - 2; i++)
        {
            current = prev2 + prev1;

            Console.WriteLine(current);

            prev2 = prev1;
            prev1 = current;
        }
    }

    private static void FibonacciRecursion(int length, int currentStep, int prev2, int prev1)
    {
        if (currentStep == 1)
        {
            Console.WriteLine(prev2);
            Console.WriteLine(prev1);
        }

        int current = prev2 + prev1;

        Console.WriteLine(current);

        if (currentStep < length - 2)
            FibonacciRecursion(length, currentStep + 1, prev1, current);
    }

    public static void FibonacciRecursionHelper(int length)
    {
        int prev2 = 0;
        int prev1 = 1;

        int currentStep = 1;

        FibonacciRecursion(length, currentStep, prev2, prev1);
    }

    private static int FindFibonacci(int n)
    {
        if (n <= 1)
            return n;

        return FindFibonacci(n - 1) + FindFibonacci(n - 2);
    }

    public static int FindFibonacciHelper(int n) => FindFibonacci(--n);
}