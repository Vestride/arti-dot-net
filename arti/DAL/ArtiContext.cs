using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using arti.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace arti.DAL
{
    public class ArtiContext : DbContext
    {
        public DbSet<Artifact> Artifacts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}