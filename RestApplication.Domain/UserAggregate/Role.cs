using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApplication.Domain.UserAggregate
{
    public class Role
    {
        [Key]
        public virtual  Guid Id { get; set; }

        [StringLength(50)]
        public virtual  string Name { get; set; }

        public virtual  RoleGroup RoleGroup { get; set; }

        public virtual  RecordInformation RecordInformation { get; set; } 

        public virtual  ICollection<User> Users { get; set; }
    }
}
