using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace RN.Tasks.Core
{
    public class AppSettings
    {
        [JsonProperty(Required = Required.Always)]
        public string ConnectionString { get; set; }

        public static AppSettings Get()
        {
            var path = Assembly.GetExecutingAssembly().Location;
            var filePath = Path.Combine(Path.GetDirectoryName(path), "settings.json");

            if (!File.Exists(filePath)) return new AppSettings();

            string strSettings;
            
            using (var sr = new StreamReader(filePath)) strSettings = sr.ReadToEnd();

            try
            {
                var settings = JsonConvert.DeserializeObject<AppSettings>(strSettings);
                return settings;
            }
            catch (Exception e)
            {
                throw new Exception("Incorrect settings file", e);
            }
        }
    }
}
