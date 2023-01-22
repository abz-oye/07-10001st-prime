using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int index = 1;
		List<int> primes = new List<int> { 1 };
		int i = primes[index - 1];
		while (primes.Count<10001)
		{
			i += 2;
			bool isPrime = true;
			for (int j = 2; j < i / 2; j++)
			{
				if (i%j != 0) {
					continue;
				}
				isPrime = false;
				break;
			}
			if (!isPrime) {
				continue;
			} 
			primes.Add(i);
			index++;
		}
		Console.WriteLine(primes[10000]);
		Console.ReadKey();
    }
}
