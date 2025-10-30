using System;

public class Solution {
    
    public static int powerSum(int X, int N) {
        return CountWays(X, N, 1);
    }
    
    private static int CountWays(int remaining, int power, int num) {
        int value = (int)Math.Pow(num, power);
        
        // Base cases
        if (remaining == 0) return 1;
        if (remaining < 0 || value > remaining) return 0;
        
        // Two choices:
        // 1. Include the current number
        // 2. Skip the current number and move to next
        int include = CountWays(remaining - value, power, num + 1);
        int exclude = CountWays(remaining, power, num + 1);
        
        return include + exclude;
    }

    public static void Main(string[] args) {
        int X = Convert.ToInt32(Console.ReadLine());
        int N = Convert.ToInt32(Console.ReadLine());
        
        int result = powerSum(X, N);
        Console.WriteLine(result);
    }
}
