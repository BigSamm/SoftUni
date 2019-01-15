namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var className = typeof(BlackBoxInteger).FullName;
            var classType = Type.GetType(className);
            var classInstance = Activator.CreateInstance(classType, true);

            var fieldName = "innerValue";
            var field = classType.GetField(fieldName,
                BindingFlags.Instance | BindingFlags.NonPublic);

            string inputLine;
            while((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split('_');
                var command = tokens[0];
                var num = int.Parse(tokens[1]);

                var currentMethod = classType.GetMethod(command,
                    BindingFlags.Instance | BindingFlags.NonPublic);
                currentMethod.Invoke(classInstance, new object[] { num });
                
                var result = field.GetValue(classInstance);
                Console.WriteLine(result);
            }
        }
    }
}
