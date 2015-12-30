using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApplication.Domain.UserAggregate
{
    public class RoleGroup
    {
        [Key]
        public virtual Guid Id { get; set; }

        [StringLength(50)]
        public virtual string RoleGroupName { get; set; }

        public virtual RoleLevel RoleLevel { get; set; }

        public virtual RecordInformation RecordInformation { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
