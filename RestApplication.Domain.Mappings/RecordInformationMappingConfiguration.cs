using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApplication.Domain.Mappings
{
    public class RecordInformationMappingConfiguration : EntityTypeConfiguration<RecordInformation>
    {
        public RecordInformationMappingConfiguration()
        {
            this.Property(x => x.CreationDate).HasColumnName("CreationDate");

            this.Property(x => x.IpAddress).HasColumnName("IpAddress");

            this.Property(x => x.IsActive).HasColumnName("IsActive");

            this.Property(x => x.IsDeleted).HasColumnName("IsDeleted");

            this.Property(x => x.LastModifiedDate).HasColumnName("LastModifiedDate");

            this.Property(x => x.IsActive).IsRequired();

            this.Property(x => x.IsActive).IsRequired();

            this.Property(x => x.CreationDate).IsRequired();

            this.Property(x => x.IpAddress).IsRequired();

        }
    }
}
