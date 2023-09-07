using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise
{
    public class CodeBuilder
    {
        private readonly List<Reference> referenceList = new();
        private const int indentSize = 2;
        private readonly string className;


        public CodeBuilder(string className)
        {
            this.className = className;
        }


        public CodeBuilder AddField(string name, string type)
        {
            referenceList.Add(new(name, type));
            return this;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");

            foreach (var rf in referenceList)
            {
                sb.Append(new string(' ', indentSize));
                sb.AppendLine($"public {rf.Type} {rf.Name};");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }


        private readonly struct Reference
        {
            public readonly string Name;
            public readonly string Type;


            public Reference(string name, string type)
            {
                Name = name;
                Type = type;
            }
        }
    }
}
