using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arti.Models
{
    public class TeamMember
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NiceName { get; set; }
        public string ImposterName { get; set; }
        public string Role { get; set; }
        public virtual string[] Skills { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Portfolio { get; set; }
    }
}