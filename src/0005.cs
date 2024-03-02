class Problem5
{
    //copied
    public static void afunc(int m, int n)
    {
        int limit = n;

        List<int> primes = GetPrimes(limit);

        Dictionary<int, int> factors = new Dictionary<int, int>();
        foreach (int prime in primes)
        {
            factors[prime] = 1;
        }

        for (int x = 2; x <= limit; x++)
        {
            Dictionary<int, int> primeFactors = GetPrimeFactors(x, primes);
            foreach (var factor in primeFactors)
            {
                factors[factor.Key] = Math.Max(factor.Value, factors[factor.Key]);
            }
        }

        int result = 1;
        foreach (var factor in factors)
        {
            result *= (int)Math.Pow(factor.Key, factor.Value);
        }

        Console.WriteLine(result);
    }

    static List<int> GetPrimes(int limit)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    static bool IsPrime(int n)
    {
        for (int x = 2; x <= Math.Floor(Math.Sqrt(n)); x++)
        {
            if (n % x == 0)
            {
                return false;
            }
        }
        return true;
    }

    static Dictionary<int, int> GetPrimeFactors(int n, List<int> primes)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        foreach (int prime in primes)
        {
            while (n % prime == 0)
            {
                if (!result.ContainsKey(prime))
                {
                    result[prime] = 0;
                }
                result[prime]++;
                n = n / prime;
            }
        }
        return result;
    }
}