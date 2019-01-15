using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(this.Name);
            foreach (var document in this.Documents)
            {
                result.Append(string.Join(Environment.NewLine, document));
            }

            return result.ToString();
        }
    }
}
