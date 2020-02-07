using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbniProjhet
{
	class Program
	{
		static void Main(string[] args)
		{
			byte Bajt = 255;
			sbyte BajtSaZnakom = 127;

			int CeoBroj;			
			int x = -27;
			uint y = 10;

			long OgromanBroj = 4;

			double Drugi = 3.4;
			decimal Treci = (decimal)1.45;

			bool Logicki = false;
			Logicki = true;

			char Karakter = 'a';
			string NizKaratkera = "Sta god hocemo ";

			Console.WriteLine("Float " + sizeof(float) + " bajta");
			Console.WriteLine("Double " + sizeof(double) + " bajta");
			Console.WriteLine("Decimal " + sizeof(decimal) + " bajta");
			Console.WriteLine("Long " + sizeof(long) + " bajta");
			Console.WriteLine("Min za int: " + int.MinValue);
			Console.WriteLine("Max za int: " + int.MaxValue);
			Console.WriteLine("Min za uint: " + uint.MinValue);
			Console.WriteLine("Max za uint: " + uint.MaxValue);
			Console.WriteLine("Min za long: " + long.MinValue);
			Console.WriteLine("Max za long: " + long.MaxValue);
			Console.WriteLine("Min za ulong: " + ulong.MinValue);
			Console.WriteLine("Max za ulong: " + ulong.MaxValue);
			Console.ReadKey();
		}
	}
}
