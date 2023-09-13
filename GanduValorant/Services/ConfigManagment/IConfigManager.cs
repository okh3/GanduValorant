using GanduValorant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.ConfigManager
{
    public interface IConfigManager
    {
        void Init();
        void Save(Config config);
        Config Load();
    }
}
