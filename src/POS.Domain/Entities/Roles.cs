using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int State { get; set; }
        public ICollection<MenuRoles> MenuRoles { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
