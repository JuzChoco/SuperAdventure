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

        //* New properties added to use other classes as its Datatype (Lesson 09.1) *//
        public Item RewardItem { get; set; }

        //* Created collection of objects  (Lesson 10.1) *//
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
        public Quest(int id, String name, String description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExpereincePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            //* Created collection of objects and set it to an empty list; if it is not declared here, it will be considred a null set which cannot add anything into it(Lesson 10.1) *//
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
