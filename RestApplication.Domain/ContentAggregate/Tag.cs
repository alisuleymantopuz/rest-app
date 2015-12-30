using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApplication.Domain.UserAggregate;

namespace RestApplication.Domain.ContentAggregate
{
    public class Tag
    {
        [Key]
        public virtual Guid Id { get; set; }

        [StringLength(250)]
        public virtual string Name { get; set; }

        public virtual User User { get; set; }

        public virtual RecordInformation RecordInformation { get; set; }
    }
}
