using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApplication.Domain.UserAggregate;
using System.ComponentModel.DataAnnotations;

namespace RestApplication.Domain
{
    public class RecordInformation
    {
        public virtual DateTime? CreationDate { get; set; }

        public virtual DateTime? LastModifiedDate { get; set; }

        [StringLength(50)]
        public virtual string IpAddress { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual bool IsDeleted { get; set; }
    }
}
