using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MCY_CV3.Models.Tables;

namespace MCY_CV3.Models.Context
{
    public class CV_Context:DbContext
    {
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ComChannel> ComChannels { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorkExp> WorkExps { get; set; }
        public DbSet<Admin> Admin { get; set; }

    }
}