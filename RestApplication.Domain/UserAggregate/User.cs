using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApplication.Domain.ContentAggregate;

namespace RestApplication.Domain.UserAggregate
{
    public class User
    {
        [Key]
        public virtual Guid Id { get; set; }

        [StringLength(50)]
        public virtual string UserName { get; set; }

        [StringLength(50)]
        public virtual string Email { get; set; }

        [StringLength(250)]
        public virtual string Password { get; set; }

        public virtual Role Role { get; set; }

        public virtual RecordInformation RecordInformation { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
