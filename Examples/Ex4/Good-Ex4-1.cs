using System;
using System.IO;
using System.Linq;

namespace ExplicitDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                FavoriteColor = "Blue",
                Title = "Mr.",
                Fullname = "Steve Smith"
            };

            var response = new PersonalizedResponse(new SimpleFileLogger(), new SystemDateTime());

            Console.WriteLine(response.GetResponse(customer));
            Console.ReadLine();
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class SimpleFileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter logFile = new StreamWriter(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "logfile.txt")))
            {
                logFile.WriteLine(message);
            }
        }
    }

    public interface IDateTime
    {
        DateTime Now { get; }
    }

    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }

    public class Customer
    {
        public string FavoriteColor { get; set; }
        public string Title { get; set; }
        public string Fullname { get; set; }
    }

    public class PersonalizedResponse
    {
        private readonly ILogger _logger;

        private readonly IDateTime _dateTime;

        public PersonalizedResponse(ILogger logger,
            IDateTime dateTime)
        {
            this._dateTime = dateTime;
            this._logger = logger;
        }

        public string GetResponse(Customer customer)
        {
            _logger.Log("Generating personalized response.");
            string formatString = "Good {0}, {1} {2}! Would you like a {3} widget today?";
            string timeOfDay = "afternoon";
            if (_dateTime.Now.Hour < 12)
            {
                timeOfDay = "morning";
            }
            if (_dateTime.Now.Hour > 17)
            {
                timeOfDay = "evening";
            }
            return String.Format(formatString, timeOfDay,
                customer.Title,
                customer.Fullname,
                customer.FavoriteColor);
        }
    }
}
