namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            var instance = Activator.CreateInstance(type, true);

            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] input = line.Split("_");
                string methodName = input[0];
                int value = int.Parse(input[1]);

                var method = methods.FirstOrDefault(x => x.Name == methodName);

                method.Invoke(instance, new object[] { value });

                var field = type.GetField("innerValue",BindingFlags.Instance | BindingFlags.NonPublic);

                Console.WriteLine(field.GetValue(instance));

                
            }

        }
    }
}
