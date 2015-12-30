using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApplication.Domain.UserAggregate;

namespace RestApplication.Domain.Mappings
{
    public class RoleMappingConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleMappingConfiguration()
        {
            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("Roles");

            this.Property(x => x.Id).HasColumnName("Id");

            this.Property(x => x.Name).HasColumnName("Name");

            this.Property(x => x.Name).IsRequired().HasMaxLength(50);

            this.HasRequired(x => x.RoleGroup);
        }
    }
}
