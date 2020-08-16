using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AffinityChanger.Classes
{
    public static class Cache
    {
        static string appdata_dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string cache_dir = Path.Combine(appdata_dir, "alexmfv");

        public static void CheckDirectory()
        {
            if (!Directory.Exists(cache_dir))
                Directory.CreateDirectory(cache_dir);
        }

        public static void SaveOptions(params string[] options)
        {
            CheckDirectory();
            List<Tuple<string, string>> values = new List<Tuple<string, string>>();

            values.Add(new Tuple<string, string>("win_start", options[0]));
            values.Add(new Tuple<string, string>("hide_taskbar", options[1]));
            values.Add(new Tuple<string, string>("prompt_exit", options[2]));

            WriteToFile("settings.json", values.ToArray());
        }

        public static AppSettings LoadOptions()
        {
            AppSettings settings = new AppSettings();

            if (File.Exists(cache_dir + "\\settings.json"))
                if (new FileInfo(cache_dir + "\\settings.json").Length > 0)
                    settings = ParseAppSettings(JObject.Parse(File.ReadAllText(cache_dir + "\\settings.json")));

            return settings;
        }

        public static void WriteToFile(string filename, Tuple<string, string>[] keyPairs)
        {
            using (StreamWriter file = File.CreateText(cache_dir + "\\" + filename))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                JObject obj = new JObject();

                foreach(Tuple<string, string> tuple in keyPairs)
                    obj.Add(tuple.Item1, tuple.Item2);

                obj.WriteTo(writer);
            }
        }

        static AppSettings ParseAppSettings(JObject obj)
        {
            try
            {
                AppSettings collection = new AppSettings();

                foreach (KeyValuePair<string, JToken> pair in obj)
                {
                    switch (pair.Key)
                    {
                        case "win_start": collection.win_start = (bool)pair.Value; break;
                        case "hide_taskbar": collection.hide_taskbar = (bool)pair.Value; break;
                        case "prompt_exit": collection.prompt_exit = (bool)pair.Value; break;
                            //Add other user settings here, as they are necessary
                    }
                }
                return collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
