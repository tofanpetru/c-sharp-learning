using Microsoft.Extensions.Configuration;

using System;

namespace BindJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = AppSettings.Instance.ConnectionString;

            Console.WriteLine(connectionString);
            Console.Read();
        }
    }
}
