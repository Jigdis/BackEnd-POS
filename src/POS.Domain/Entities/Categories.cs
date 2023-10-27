using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Required]
        public int AuditCreateUser { get; set; }

        [Required]
        public DateTime AuditCreateDate { get; set; }

        public int? AuditUpdateUser { get; set; }
        public DateTime? AuditUpdateDate { get; set; }
        public int? AuditDeleteUser { get; set; }
        public DateTime? AuditDeleteDate { get; set; }
        public int State { get; set; }
        public ICollection<Products> Products { get; set; }

    }
}
