using System;
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

        public Location(int id, String name, String description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
