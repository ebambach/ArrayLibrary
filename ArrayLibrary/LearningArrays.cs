using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary {
	public class LearningArrays {
		public static int[,] Bowling = {
			{ 20, 19, 9, 18, 8, 19, 9, 30, 28, 19 },
			{ 30, 28, 18, 18, 8, 19, 9, 30, 28, 19 },
			{ 9, 9, 9, 18, 8, 19, 9, 30, 30, 50 }
		};
		public static List<int> GradingScores = new List<int>();

		//Sets up a generic list of integers, with nothing in it yet.  Will be used
		//to list high temperatures for Sepetember 2017, as of 9/11
		public static List<int> SeptemberHighs = new List<int>();
    }
}
