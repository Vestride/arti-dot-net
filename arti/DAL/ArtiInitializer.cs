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

            var artifact_6471 = new Artifact
            {
                arm = 196,
                bbox = 560,
                frameSize = 0,
                head = 202,
                height = 310,
                id = "artifact_6471",
                leg = 576,
                lhandX = 413.4297,
                lhandY = 223.2944,
                owner = "nancy",
                processed = true,
                rhandX = 460.7667,
                rhandY = 35.41784,
                stars = 4,
                timestamp = 20120227015057,
                torso = 269,
                views = 26,
                wingspan = 499
            };

            var artifact_9616 = new Artifact
            {
                arm = 183,
                bbox = 560,
                frameSize = 0,
                head = 232,
                height = 271,
                id = "artifact_9616",
                leg = 517,
                lhandX = 252.7756,
                lhandY = 309.0474,
                owner = "Vestride",
                processed = true,
                rhandX = 563.5798,
                rhandY = 380.6147,
                stars = 2,
                timestamp = 20120426014600,
                torso = 306,
                views = 21,
                wingspan = 445
            };


            var artifact_9483 = new Artifact
            {
                arm = 130,
                bbox = 560,
                frameSize = 0,
                head = 345,
                height = 282,
                id = "artifact_9483",
                leg = 569,
                lhandX = 640,
                lhandY = 270.0056,
                owner = "Vestride",
                processed = true,
                rhandX = 640,
                rhandY = 189.129,
                stars = 1,
                timestamp = 20120227022514,
                torso = 417,
                views = 3,
                wingspan = 262
            };

            var artifact_4409 = new Artifact
            {
                arm = 152,
                bbox = 560,
                frameSize = 0,
                head = 388,
                height = 194,
                id = "artifact_4409",
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
                views = 12,
                wingspan = 329,
                featured = true
            };

            var artifact_9972 = new Artifact
            {
                arm = 152,
                bbox = 560,
                frameSize = 0,
                head = 388,
                height = 194,
                id = "artifact_9972",
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
                views = 6,
                wingspan = 329,
                featured = true
            };

            var artifact_8715 = new Artifact
            {
                arm = 152,
                bbox = 560,
                frameSize = 0,
                head = 388,
                height = 194,
                id = "artifact_8715",
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
                views = 4,
                wingspan = 329,
                featured = true
            };

            var artifact_2428 = new Artifact
            {
                arm = 152,
                bbox = 560,
                frameSize = 0,
                head = 388,
                height = 194,
                id = "artifact_2428",
                leg = 446,
                lhandX = 628.3373,
                lhandY = 272.2365,
                owner = "anonymous",
                processed = true,
                rhandX = 613.5857,
                rhandY = 334.7308,
                stars = 1,
                timestamp = 20120228024040,
                torso = 458,
                views = 10,
                wingspan = 329,
                featured = true
            };

            var artifacts = new List<Artifact>
            {
                artifact_5566,
                artifact_5491,
                artifact_1176,
                artifact_6471,
                artifact_9616,
                artifact_9483,
                artifact_4409,
                artifact_9972,
                artifact_8715,
                artifact_2428
            };
            artifacts.ForEach(a => context.Artifacts.Add(a));
            context.SaveChanges();

            var users = new List<User>
            {
                new User {
                    username = "dro",
                    Artifacts = new List<Artifact> { artifact_5566 }
                },

                new User {
                    username = "weez",
                    Artifacts = new List<Artifact> { artifact_5491 }
                },

                new User {
                    username = "Vestride",
                    Artifacts = new List<Artifact> { artifact_9483, artifact_9616 }
                },
                new User {
                    username = "nancy",
                    Artifacts = new List<Artifact> { artifact_6471 }
                },

                new User {
                    username = "anonymous",
                    Artifacts = new List<Artifact> { artifact_1176, artifact_4409, artifact_9972, artifact_8715, artifact_2428 }
                }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            string[] glenSkills = { "Front-end", "PHP", "CSS" };

            var teamMembers = new List<TeamMember>
            {
                new TeamMember {
                    Name = "Glen Cheney",
                    NiceName = "glen_cheney",
                    ImposterName = "Concise Imposter",
                    Role = "Developer",
                    Skills = glenSkills,
                    Description = "I&rsquo;m a developer with a passion for the frontend. I enjoy keeping up with new technologies and making the web awesome.",
                    Username = "Vestride",
                    Portfolio = "http://glencheney.com"
                },

                new TeamMember {
                    Name = "Mike Higham",
                    NiceName = "mike_higham",
                    ImposterName = "Command Imposter",
                    Role = "Developer",
                    Skills = new string[3] { "JavaScript, PHP, CSS", "C#, Java", "Communication" },
                    Description = "I&rsquo;m a web developer with a focus on the bleeding-edge, if it&rsquo;s new and its on the web, I want to be a part of it.",
                    Username = "happyearmuffs",
                    Portfolio = "http://michaelhigham.com"
                },

                new TeamMember {
                    Name = "Andrew Kiproff",
                    NiceName = "andrew_kiproff",
                    ImposterName = "Husky Imposter",
                    Role = "Developer",
                    Skills = new string[] { "C#", "Front-end, PHP", "Proce55ing" },
                    Description = "New Media: Interactive Developer with a focus on simple, unique designs and layouts",
                    Username = "dro",
                    Portfolio = "http://andrewkiproff.com"
                },

                new TeamMember {
                    Name = "Jesse Thoman",
                    NiceName = "jesse_thoman",
                    ImposterName = "Bubbly Imposter",
                    Role = "Designer",
                    Skills = new [] { "Illustration", "Motion Graphics", "Writing" },
                    Description = "A designer, illustrator, and writer, with a love for all things film. I have a marketer&rsquo;s mind-set and am always thinking of how projects and products will interact with people.",
                    Username = "everrae",
                    Portfolio = "http://jessethoman.com"
                },

                new TeamMember {
                    Name = "Jake Gross",
                    NiceName = "jake_gross",
                    ImposterName = "Beardy Imposter",
                    Role = "Designer",
                    Skills = new [] { "Visual Design", "Interactive Design", "User Experience" },
                    Description = "I love working with typography, and 2d design, and the web. Making sure that experiences don&rsqou;t stay on the web is something I try to bring to every project. Little things are my speciality, adding to experience of the user.",
                    Username = "beard",
                    Portfolio = "http://jakegross.com"
                },

                new TeamMember {
                    Name = "Matt Olpinski",
                    NiceName = "matt_olpinski",
                    ImposterName = "Polish Imposter",
                    Role = "Designer",
                    Skills = new [] { "Interface Design", "Motion Graphics", "Web Design &amp; Development" },
                    Description = "I&rsquo;m a multi-talented interface designer with a passion for motion graphics and web design. I have a confident personality and a creative mind that allow me to produce top-notch work. I love the details that make good projects great.",
                    Username = "mattolpinski",
                    Portfolio = "http://mattolpinski.com"
                }
            };
            teamMembers.ForEach(member => context.TeamMembers.Add(member));
            context.SaveChanges();
        }
    }
}

        