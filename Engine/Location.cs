﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        //* New properties added to use other classes as its Datatype (Lesson 09.1) *//
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, String name, String description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;

            //* New parameters added to use other classes as its Datatype (Lesson 09.1) *//
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailablHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
