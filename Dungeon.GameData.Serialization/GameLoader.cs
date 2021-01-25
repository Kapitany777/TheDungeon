using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.GameData.Serialization
{
    public class GameLoader
    {
        public Game Load(string fileName)
        {
            Game loaded = null;

            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                loaded = (Game)formatter.Deserialize(stream);
            }

            return loaded;
        }
    }
}
