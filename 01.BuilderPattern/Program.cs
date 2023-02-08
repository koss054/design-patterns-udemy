namespace BuilderPattern
{
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            var firstBuilder = new CodeBuilder("FirstClass")
                .AddField("Name", "string")
                .AddField("Age", "int");

            Console.WriteLine(firstBuilder);
        }
    }

    public class Field
    {
        public string Name;
        public string Type;

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }

    public class Class
    {
        public string Name;
        public List<Field> Fields = new List<Field>();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"public class {Name}")
              .AppendLine("{");

            foreach (var field in Fields)
            {
                sb.AppendLine($"  {field};");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class CodeBuilder
    {
        private Class _class = new Class();

        public CodeBuilder(string rootName)
        {
            _class.Name = rootName;
        }

        public CodeBuilder AddField(string name, string type)
        {
            _class.Fields.Add(new Field { Name = name, Type = type });
            return this;    // Fluent builder, allowing us to chain this method with itself.
        }

        public override string ToString()
        {
            return _class.ToString();
        }
    }
}