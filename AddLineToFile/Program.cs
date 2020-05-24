using System;
using System.IO;

namespace AddLineToFile
{
	class Program
	{
		static void Main(string[] args)
		{
			var mockupArgs = new string[] { @"c:\Users\emsenturk\Desktop\services", @"sapmsCO3 3601/tcp" };
			args = mockupArgs;

			if (args.Length != 2)
			{
				Console.WriteLine("2 parametre geçmediniz !!!");
				Console.ReadLine();
				return;
			}

			var fullPath = args[0];
			var lineToAdd = args[1];

			if (!File.Exists(fullPath))
			{
				Console.WriteLine("Dosya bulunamadı !!!");
				//Console.ReadLine();
				return;
			}

			var allLines = File.ReadAllText(fullPath);
			if (allLines.Contains(lineToAdd))
			{
				Console.WriteLine("Eklenecek satır zaten mevcut !!!");
				//Console.ReadLine();
				return;
			}

			File.AppendAllText(fullPath, lineToAdd + Environment.NewLine);

			Console.WriteLine("İşlem tamamlanmıştır!");
			//Console.ReadLine();
		}
	}
}
