using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Menus")]
    public class Menus
    {
        [Key]
        public int MenuId { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(150)]
        public string URL { get; set; }

        public int? FatherId { get; set; }
        public int? State { get; set; }
        public ICollection<MenuRoles> MenuRoles { get; set; }

    }
}
