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
    public class RoleGroupMappingConfiguration : EntityTypeConfiguration<RoleGroup>
    {
        public RoleGroupMappingConfiguration()
        {
            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("RoleGroups");

            this.Property(x => x.Id).HasColumnName("Id");

            this.Property(x => x.RoleGroupName).HasColumnName("RoleGroupName");

            this.Property(x => x.RoleGroupName).IsRequired().HasMaxLength(50);

            this.Property(x => x.RoleLevel).HasColumnName("RoleLevel");

            this.Property(x => x.RoleLevel).IsRequired().HasColumnType("int");

        }
    }
}
