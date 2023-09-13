using GanduValorant.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.ConfigManager
{
    public class ConfigManager : IConfigManager
    {
        private string _path;
        public ConfigManager(string path)
        {
            _path = path;
        }

        public void Init()
        {
            if (!File.Exists(_path))
            {
                StreamWriter streamWriter = File.CreateText(_path);

                streamWriter.Flush();
                streamWriter.Dispose();
            }
        }

        public Config Load()
        {
            if (!File.Exists(_path)) Init();

            List<string> lines = File.ReadAllLines(_path).ToList();
            Config config = new Config(0,0,0,0);

            foreach (var line in lines)
            {
                var strings = line.Split(',');

                int.TryParse(strings[0], out int delayTime);
                int.TryParse(strings[1], out int pixleSens);
                int.TryParse(strings[2], out int pixleWidth);
                int.TryParse(strings[3], out int pixleHeight);

                 config = new Config(delayTime, pixleSens, pixleWidth, pixleHeight);
            }
            return config;
        }

        public void Save(Config config)
        {
            if (!File.Exists(_path)) Init();

            List<string> lines = new List<string>
            {
                $"{config.DelayTimeMS},{config.PixleSensitivity},{config.TriggerPixleWidth},{config.TriggerPixleHeight}"
            };

            File.WriteAllLines(_path, lines);
        }
    }
}
