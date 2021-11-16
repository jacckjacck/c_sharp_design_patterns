namespace BuilderCodingExercise
{
    internal class CodeBuilder
    {
        private Class classInfo = new();
        public CodeBuilder(string className)
        {
            classInfo.Name = className;
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            classInfo.Fields.Add(new ClassFields { fieldName = fieldName, fieldType = fieldType });
            return this;
        }

        public override string ToString()
        {
            return classInfo.ToString();
        }
    }
}
