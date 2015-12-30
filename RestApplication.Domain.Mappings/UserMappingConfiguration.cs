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
    public class UserMappingConfiguration : EntityTypeConfiguration<User>
    {
        public UserMappingConfiguration()
        {
            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("Users");

            this.Property(x => x.Id).HasColumnName("Id");

            this.Property(x => x.UserName).HasColumnName("UserName");

            this.Property(x => x.UserName).IsRequired().HasMaxLength(50);

            this.Property(x => x.Email).HasColumnName("Email");

            this.Property(x => x.Email).IsRequired().HasMaxLength(50);

            this.Property(x => x.Password).HasColumnName("Password");

            this.Property(x => x.Password).IsRequired().HasMaxLength(250);

            this.HasRequired(x => x.Role);
        }
    }
}
