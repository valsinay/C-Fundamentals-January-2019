namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {

            var fields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var builder = new StringBuilder();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "HARVEST")
                {
                    break;
                }

                if (line == "public")
                {
                    var publicFields = fields.Where(x => x.IsPublic).ToList();
                    AppendMethod(publicFields, builder);
                }
                else if (line == "private")
                {
                    var privateFields = fields.Where(x => x.IsPrivate).ToList();
                    AppendMethod(privateFields, builder);
                }
                else if (line == "protected")
                {
                    var protectedFields = fields.Where(x => x.IsFamily).ToList();
                    AppendMethod(protectedFields, builder);
                }
                else
                {
                    var allFieldss = fields.ToList();
                    AppendMethod(allFieldss, builder);
                }

            }
            Console.WriteLine(builder.ToString().Trim());

        }

        private static void AppendMethod(List<FieldInfo> fields, StringBuilder builder)
        {
            foreach (var field in fields)
            {
                var accessmodifier = field.Attributes.ToString().ToLower();

                if (accessmodifier.Equals("family"))
                {
                   accessmodifier = "protected";
                }
                builder.AppendLine($"{accessmodifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}

