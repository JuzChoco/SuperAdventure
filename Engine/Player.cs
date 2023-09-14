using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        //* Created collection of objects  (Lesson 10.1) *//
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quest { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experincePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experincePoints;
            Level = level;

            //* Created collection of objects and set it to an empty list; if it is not declared here, it will be considred a null set which cannot add anything into it(Lesson 10.1) *//
            Inventory = new List<InventoryItem>();
            Quest = new List<PlayerQuest>();
        }
    }
}
