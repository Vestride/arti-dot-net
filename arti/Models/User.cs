using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arti.Models
{
    public class User
    {
        public string username { get; set; }
        public ICollection<Artifact> Artifacts { get; set; }
    }
}