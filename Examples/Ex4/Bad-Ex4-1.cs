using System;
using System.IO;
using System.Linq;

namespace ImplicitDependencies
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
            Context.CurrentCustomer = customer;

            var response = new PersonalizedResponse();

            Console.WriteLine(response.GetResponse());
            Console.ReadLine();
        }
    }

    public static class Context
    {
        public static Customer CurrentCustomer { get; set; }

        public static void Log(string message)
        {
            using (StreamWriter logFile = new StreamWriter(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "logfile.txt")))
            {
                logFile.WriteLine(message);
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
        public string GetResponse()
        {
            Context.Log("Generating personalized response.");
            string formatString = "Good {0}, {1} {2}! Would you like a {3} widget today?";
            string timeOfDay = "afternoon";
            if (DateTime.Now.Hour < 12)
            {
                timeOfDay = "morning";
            }
            if (DateTime.Now.Hour > 17)
            {
                timeOfDay = "evening";
            }
            return String.Format(formatString, timeOfDay,
                Context.CurrentCustomer.Title,
                Context.CurrentCustomer.Fullname,
                Context.CurrentCustomer.FavoriteColor);
        }
    }
}
