using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int RewardExpereincePoints { get; set; }
        public int RewardGold { get; set; }

        public Quest(int id, String name, String description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExpereincePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
