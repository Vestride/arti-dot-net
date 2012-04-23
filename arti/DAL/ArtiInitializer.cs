using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using arti.Models;

namespace arti.DAL
{
    public class ArtiInitializer : DropCreateDatabaseIfModelChanges<ArtiContext>
    {
        protected override void Seed(ArtiContext context)
        {
            var artifact_5566 = new Artifact
            {
                id = "artifact_5546",
                timestamp = 20120218042045,
                wingspan = 498,
                head = 128,
                lhandX = 5.700663,
                lhandY = 288.2898,
                rhandX = 203.0733,
                rhandY = 312.5627,
                torso = 196,
                height = 328,
                arm = 178,
                leg = 605,
                bbox = 533,
                frameSize = 16558,
                views = 1,
                stars = 0,
                processed = true,
                owner = "dro",
                featured = false
            };

            Artifact artifact_5491 = new Artifact
            {
                id = "artifact_5491",
                timestamp = 20120227025553,
                wingspan = 431,
                head = 228,
                lhandX = 271.3583,
                lhandY = 188.4483,
                rhandX = 355.6494,
                rhandY = 193.5615,
                torso = 295,
                height = 228,
                arm = 154,
                leg = 491,
                bbox = 560,
                frameSize = 0,
                views = 15,
                stars = 3,
                processed = true,
                owner = "weez",
                featured = false
            };

            var artifact_1176 = new Artifact
            {
                arm = 152,
                bbox = 560,
                frameSize = 0,
                head = 388,
                height = 194,
                id = "artifact_1176",
                leg = 446,
                lhandX = 628.3373,
                lhandY = 272.2365,
                owner = "anonymous",
                processed = true,
                rhandX = 613.5857,
                rhandY = 334.7308,
                stars = 0,
                timestamp = 20120227024040,
                torso = 458,
                views = 2,
                wingspan = 329,
                featured = true
            };

            var artifacts = new List<Artifact>
            {
                artifact_5566,
                artifact_5491,
                artifact_1176
            };
            artifacts.ForEach(a => context.Artifacts.Add(a));
            context.SaveChanges();

            //var users = new List<User>
            //{
            //    new User {
            //        username = "dro",
            //        Artifacts = new List<Artifact> { artifact_5566 }
            //    },

            //    new User {
            //        username = "weez",
            //        Artifacts = new List<Artifact> { artifact_5491 }
            //    },

            //    new User {
            //        username = "anonymous",
            //        Artifacts = new List<Artifact> { artifact_1176 }
            //    }
            //};
            //users.ForEach(u => context.Users.Add(u));
            //context.SaveChanges();
        }
    }
}

        