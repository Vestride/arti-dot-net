using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arti.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public virtual ICollection<Artifact> Artifacts { get; set; }
    }
}