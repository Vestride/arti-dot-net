using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace arti.Models
{
    public class Artifact
    {
        //[Key]
        public string id { get; set; }
        public long timestamp { get; set; }
        public int wingspan { get; set; }
        public int head { get; set; }
        public double lhandX { get; set; }
        public double lhandY { get; set; }
        public double rhandX { get; set; }
        public double rhandY { get; set; }
        public int torso { get; set; }
        public int height { get; set; }
        public int arm { get; set; }
        public int leg { get; set; }
        public int bbox { get; set; }
        public int frameSize { get; set; }
        public int views { get; set; }
        public int stars { get; set; }
        public bool processed { get; set; }
        public string owner { get; set; }

        public bool featured { get; set; }
    }
}