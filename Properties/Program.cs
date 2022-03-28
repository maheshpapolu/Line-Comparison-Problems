using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_two__lines_based__on_the_endPoints
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the start and end points of the first line: ");
			int x1 = Convert.ToInt32(Console.ReadLine());
			int y1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the start and end points of the second line: ");
			int x2 = Convert.ToInt32(Console.ReadLine());
			int y2 = Convert.ToInt32(Console.ReadLine());
			{
				int length1, length2;
				if (x1 == y1)
				{
					int comp = y1.CompareTo(y2);
					if (comp == 0)
					{
						Console.WriteLine("lines are Equal");
					}
					else if (comp >= 0)
					{
						Console.WriteLine("Second line is Smaller than First line");
					}
				}
				else
				{
					length1 = y1 - x1;
					length2 = y2 - x2;
					int comp = length1.CompareTo(length2);
					if (comp == 0)
					{
						Console.WriteLine("Lines are equal");
					}
					else if (comp >= 0)
					{
						Console.WriteLine("Second line is smaller than first line");
					}
					else
					{
						Console.WriteLine("second line is bigger than first line");
					}

					Console.ReadLine();
				
				}
			} 
		}
    }
}
