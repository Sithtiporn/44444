using System;

class MainClass {
    static void Main(string[] args) {
      
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]); 
        int K = int.Parse(input[1]); 

        int[] populations = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); 

        int maxPopulation = 0; 
        int startIndex = -1; 

        for (int i = 0; i < N - K + 1; i++) {
            int currentPopulation = 0; 

            for (int j = i; j < i + K; j++) {
                currentPopulation += populations[j];
            }

            if (currentPopulation > maxPopulation) {
                maxPopulation = currentPopulation;
                startIndex = i;
            }
        }

        Console.WriteLine(maxPopulation);
    }
}
