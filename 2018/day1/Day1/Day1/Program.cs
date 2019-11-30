using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day1
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = args[0];
			string[] frequencies = File.ReadAllLines(path);
			int current_frequency = 0;
			foreach(string freq in frequencies)
			{
				current_frequency += int.Parse(freq);
			}
			Console.WriteLine(current_frequency);
		}
	}
}
