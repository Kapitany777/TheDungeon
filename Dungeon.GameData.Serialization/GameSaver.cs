using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.GameData.Serialization
{
    public class GameSaver
    {
        private readonly Game game;

        public GameSaver(Game game)
        {
            this.game = game;
        }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, game);
            }
        }
    }
}
