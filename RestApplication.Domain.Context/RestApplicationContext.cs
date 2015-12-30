using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApplication.Domain.ContentAggregate;
using RestApplication.Domain.Mappings;
using RestApplication.Domain.UserAggregate;

namespace RestApplication.Domain.Context
{
    public class RestApplicationContext : DbContext
    {
        public RestApplicationContext()
            : base("RestApplicationConnectionString")
        {

        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleGroup> RoleGroups { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RecordInformationMappingConfiguration());
            modelBuilder.Configurations.Add(new RoleGroupMappingConfiguration());
            modelBuilder.Configurations.Add(new RoleMappingConfiguration());
            modelBuilder.Configurations.Add(new UserMappingConfiguration());
            modelBuilder.Configurations.Add(new TagMappingConfiguration());

        }
    }
}
