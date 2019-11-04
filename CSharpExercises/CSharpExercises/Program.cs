using System;
using System.Collections.Generic;

namespace CSharpExercises
{
	public class Program
	{
		static void Main(string[] args)
		{
			var listOfNames = new List<string> { "Heather", "Jason", "Zack", "Mahathi" };

			foreach (string name in listOfNames)
			{
				Console.WriteLine(@"Employee Name: {0}", name.ToUpper());
			}
		}
	}
}
