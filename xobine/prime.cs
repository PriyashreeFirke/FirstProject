using System;
using System.Collections.Generic;
using System.Text;

/*namespace FirstProject.xobine
{
    class prime

    {
        static int primeSum(int[] arr, int n)
        {
            // Find maximum value in the array
            int max_val = arr.Max();

            // USE SIEVE TO FIND ALL PRIME NUMBERS LESS
            // THAN OR EQUAL TO max_val
            // Create a boolean array "prime[0..n]". A
            // value in prime[i] will finally be false
            // if i is Not a prime, else true.
            List<bool> prime = new List<bool>(max_val + 1);
            for (int i = 0; i < max_val + 1; i++)
                prime.Insert(i, true);

            // Remaining part of SIEVE
            prime.Insert(0, false);
            prime.Insert(1, false);
            for (int p = 2; p * p <= max_val; p++)
            {

                // If prime[p] is not changed, then
                // it is a prime
                if (prime[p] == true)
                {

                    // Update all multiples of p
                    for (int i = p * 2; i <= max_val; i += p)
                        prime.Insert(i, false);
                }
            }

            // Sum all primes in arr[]
            int sum = 0;
            for (int i = 0; i < n; i++)
                if (prime[arr[i]])
                    sum += arr[i];

            return sum;
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            Console.WriteLine(primeSum(arr, n));
        }
    }
}*/







