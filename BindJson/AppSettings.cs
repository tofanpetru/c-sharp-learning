using Microsoft.Extensions.Configuration;

namespace BindJson
{
    public class AppSettings
    {
        private static AppSettings _instance;

        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                {

                    IConfiguration config = new ConfigurationBuilder()
                       .AddJsonFile("appSettings.json", true, true)
                       .Build();
                    _instance = new AppSettings();

                    config.Bind(_instance);

                }

                return _instance;
            }
        }

        public string ConnectionString { get; set; }

        public string Path { get; set; }
    }
}