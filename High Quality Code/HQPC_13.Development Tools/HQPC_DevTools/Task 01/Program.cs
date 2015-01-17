namespace HQPC_DevTools
{
    using System;
    using log4net;
    using log4net.Appender;
    using log4net.Config;
    using log4net.Layout;

    public class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        public static void Main()
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "logProgram.txt";
            fileAppender.Layout = new SimpleLayout();
            fileAppender.AppendToFile = true;
            fileAppender.ActivateOptions();

            BasicConfigurator.Configure(fileAppender);

            Console.WriteLine("Please enter a that is divisible by 3 without remainder");
            string input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("The input is not a number - enter a number...");
                Log.Error(input);
                input = Console.ReadLine();
            }

            if (number % 3 == 0)
            {
                Log.Info("Valid input: " + number + ". Division successful!");
            }
            else
            {
                Log.Warn("Valid input: " + number + ". Division NOT successful!");
            }
        }
    }
}
