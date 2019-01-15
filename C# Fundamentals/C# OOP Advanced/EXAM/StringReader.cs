using FestivalManager.Core.IO.Contracts;

namespace FestivalManager.Core.IO
{
	public class StringReader : IReader
	{
		private readonly StringReader reader;

		public StringReader(string contents)
		{
			this.reader = new StringReader(contents);
		}

		public string ReadLine() => this.reader.ReadLine();
	}
}