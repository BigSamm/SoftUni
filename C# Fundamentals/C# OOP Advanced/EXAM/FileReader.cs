using System.IO;

// we might want to read from files idk lol ¯\_(ツ)_/¯
namespace FestivalManager.Core.IO
{
    using FestivalManager.Core.IO.Contracts;
    using System.IO;

	public class FileReader : IReader
	{
		private readonly StreamReader reader;

		public FileReader(string contents)
		{
			this.reader = new StreamReader(new FileStream(contents, FileMode.Open, FileAccess.Read & FileAccess.Write));
		}

		public string ReadLine() => this.reader.ReadLine();
	}
}