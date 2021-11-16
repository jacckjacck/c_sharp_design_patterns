using System.Text;
using System.Collections.Generic;

namespace BuilderCodingExercise
{
    internal class Class
    {
        public string Name;
        public List<ClassFields> Fields = new();

        public Class()
        {   
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}").AppendLine("{");
            foreach (var field in Fields)
            {
                sb.AppendLine($"  public {field.fieldType} {field.fieldName};");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
