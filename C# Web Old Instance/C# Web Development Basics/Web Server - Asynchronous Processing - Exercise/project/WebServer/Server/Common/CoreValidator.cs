namespace WebServer.Server.Common
{
    using System;

    public static class CoreValidator
    {
        public static void ThrowIfNull(object obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void ThrowIfNullOrWhiteSpace(string text, string name)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException($"{name} cannot be null or white space!", name);
            }
        }
    }
}
