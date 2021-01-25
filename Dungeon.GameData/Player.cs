using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.GameData
{
    [Serializable]
    public class Player : BaseData
    {
        /// <summary>
        /// The name of the player
        /// </summary>
        public string Name { get; }

        private int hitPoints;
        
        /// <summary>
        /// The current hit points of the player
        /// </summary>
        public int HitPoints
        {
            get
            {
                return hitPoints;
            }

            private set
            {
                if (hitPoints != value)
                {
                    hitPoints = value;
                    OnPropertyChanged();
                }
            }
        }

        private int level;

        /// <summary>
        /// The current level of the player
        /// </summary>
        public int Level
        {
            get
            { 
                return level;
            }

            set
            {
                if (level != value)
                {
                    level = value;
                    OnPropertyChanged();
                }
            }
        }


        public Player(string name)
        {
            this.Name = name;
            
            this.HitPoints = 15;
            this.Level = 1;
        }
    }
}
