using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Equality_of_Twolines_based_on_their_end_point
{
	 class Program
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
				if (x1 == x2)
                {
					Console.WriteLine(y1.Equals(y2));
                }
				else
                {
					length1 = y1 - x1;
					length2 = y2 - x2;
					Console.WriteLine(length1.Equals(length2));
					Console.ReadLine();
                }
            }
		}
	}
}


							
