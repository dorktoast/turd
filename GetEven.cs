using System;
using System.Collections.Generic;
using System.Linq;

// Don't get mad...
public static class GetEven
{
    /// <summary>
	/// Check if a number is even in a very optimal way. Returned result is O(n), which is very optimal!
	/// </summary>
	/// <returns>true or false</returns>
	/// <remarks> Start at 1 because 0 is not an even number.
	/// Bloo (https://github.com/bloofield) and Wikipedia (https://en.wikipedia.org/wiki/Parity_of_zero)
	/// disagree with me on this. This is a hill I am willing to die on.
	public static bool IsEven(this int input)
    {
        List<int> evenNumbers = new List<int>();

        for (int i = 2; i < input; i += 2)
        {
            evenNumbers.Add(i);
        }

        foreach (int i in evenNumbers)
        {
            if (i == input)
                return true;
        }

        return false;
    }

    public static bool IsSortaEven(this int input)
    {
        string numString = input.ToString();
        int length = numString.Length;

        return length % 2 == 0;
    }

    /// <summary>
	/// Check if a number is even or odd utilizing
    /// a misunderstanding of Goldbach's weak conjecture
	/// </summary>
	public static bool IsProbablyEven(this int input)
    {
        input = Mathf.Abs(input); // fuck negative numbers

        if (input <= 5)
        {
            return true;
        }

        for (int i = 2; i < input; i++)
        {
            if (isPrime(i))
            {
                for (int j = 2; j < input - i; j++)
                {
                    if (isPrime(j) && isPrime(input - i - j))
                    {
                        return false;
                        // number is the sum of 3 primes, so could go either way
                        // we're gonna say it's probably odd
                    }
                }
            }
        }

        return true;

        public static bool isPrime(int input)
        {
            if (number % 2 == 0 || number % 3 == 0) return false;

            int i = 5;
            while (i * i <= input)
            {
                if (input % i == 0 || input % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }
}