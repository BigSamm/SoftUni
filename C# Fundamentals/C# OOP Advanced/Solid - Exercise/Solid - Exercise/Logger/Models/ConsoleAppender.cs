using Logger.Models.Enums;
using Logger.Models.Interfaces;
using System;

namespace Logger.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel level)
        {
            this.Layout = layout;
            this.Level = level;
            this.MessagesAppended = 0;
        }

        public ILayout Layout { get; }
        public ErrorLevel Level { get; }
        public int MessagesAppended { get; private set; }

        public void Append(IError error)
        {
            var formattedError = this.Layout.FormatError(error);
            Console.WriteLine(formattedError);
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            var appenderType = this.GetType().Name;
            var layoutType = this.Layout.GetType().Name;
            var level = this.Level.ToString();

            var result = $"Appender type: {appenderType}, Layout type: {layoutType}, " +
                         $"Report level: {level}, Messages appended: {this.MessagesAppended}";
            return result;
        }
    }
}
