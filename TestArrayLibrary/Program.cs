using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace TestArrayLibrary {
	class Program {
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			//This functional mess was created to access a multidimensional array that acted as a score
			//table for three games of bowling.  As such, Counter1 can go from 0-2, and Counter2 can go
			//from 0-9 (0 being our starting position).  We cannot use .Length in place of Counter2,
			//because it returns a value of 30, 30 being how many variables total are in the array.
			//int Counter1 = 0;
			//var Sum = 0;
			//for (int Counter2 = 0; Counter1 < 3; Counter2++) {
			//	Sum += LearningArrays.Bowling[Counter1, Counter2];
			//	if (Counter2 == 9) {
			//		Counter2 = 0;
			//		Counter1++;
			//	}
			//}
			//Console.WriteLine($"{LearningArrays.Bowling.Length} is the length of the array.");
			//Console.WriteLine($"The sum of the games is {Sum}");
			//Console.WriteLine($"{Sum/Counter1} is the average.");

			//To add items to our List<int> in the GradingScores method, we use Add(), which can
			//add one item at a time.
			//LearningArrays.GradingScores.Add(97);
			//LearningArrays.GradingScores.Add(89);
			//LearningArrays.GradingScores.Add(92);
			//LearningArrays.GradingScores.Add(95);
			//LearningArrays.GradingScores.Add(90);
			//Like Add(), we can remove one item at a time.
			//LearningArrays.GradingScores.Remove(97);
			//Console.WriteLine($"The index of 90 is {LearningArrays.GradingScores.IndexOf(90)}");
			//Console.WriteLine("Let's change that to 100...");
			//var Counter = LearningArrays.GradingScores.IndexOf(90);
			//LearningArrays.GradingScores[Counter] = 100;
			//Console.WriteLine($"Where we had 90 before, we now have {LearningArrays.GradingScores[Counter]}");
			//Console.WriteLine($"The number of items in the list is {LearningArrays.GradingScores.Count()}");

			//Adds the temperature highs of 9/1 - 9/11, finds the highest value, the lowest value, and the average.
			var HighestHigh = 0;
			var LowestHigh = 212;
			var SumHigh = 0;
			var AverageHigh = 0;
			LearningArrays.SeptemberHighs.Add(65);
			LearningArrays.SeptemberHighs.Add(63);
			LearningArrays.SeptemberHighs.Add(81);
			LearningArrays.SeptemberHighs.Add(86);
			LearningArrays.SeptemberHighs.Add(77);
			LearningArrays.SeptemberHighs.Add(69);
			LearningArrays.SeptemberHighs.Add(71);
			LearningArrays.SeptemberHighs.Add(76);
			LearningArrays.SeptemberHighs.Add(74);
			LearningArrays.SeptemberHighs.Add(74);
			LearningArrays.SeptemberHighs.Add(72);

			for(int Counter = 0; Counter < LearningArrays.SeptemberHighs.Count; Counter++) {
				if (LearningArrays.SeptemberHighs[Counter] > HighestHigh) {
					HighestHigh = LearningArrays.SeptemberHighs[Counter];
				}
				if (LearningArrays.SeptemberHighs[Counter] < LowestHigh) {
					LowestHigh = LearningArrays.SeptemberHighs[Counter];
				}
				SumHigh += LearningArrays.SeptemberHighs[Counter];
			}

			AverageHigh = SumHigh / LearningArrays.SeptemberHighs.Count;

			Console.WriteLine($"The highest temperature in the current month of September was {HighestHigh}.");
			Console.WriteLine($"The lowest high temperature in the current month of September was {LowestHigh}.");
			Console.WriteLine($"The average high temperature in the current month of September was {AverageHigh}.");
		}
	}
}
