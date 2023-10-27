using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("MenuRoles")]
    public class MenuRoles
    {
        [Key]
        public int MenuRolId { get; set; }

        public int? RoleId { get; set; }

        public int? MenuId { get; set; }
        public int? State { get; set; }

        [ForeignKey("RoleId")]
        public Roles Role { get; set; }

        [ForeignKey("MenuId")]
        public Menus Menu { get; set; }
    }
}
