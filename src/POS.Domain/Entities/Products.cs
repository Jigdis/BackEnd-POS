using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Code { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Stock { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Image { get; set; }

        [Required]
        public decimal SellPrice { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int ProviderId { get; set; }

        [Required]
        public int State { get; set; }

        [Required]
        public int AuditCreateUser { get; set; }

        [Required]
        public DateTime AuditCreateDate { get; set; }

        public int? AuditUpdateUser { get; set; }
        public DateTime? AuditUpdateDate { get; set; }
        public int? AuditDeleteUser { get; set; }
        public DateTime? AuditDeleteDate { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Category { get; set; }
        [ForeignKey("ProviderId")]
        public Providers Provider { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<SaleDetail> SaleDetails { get; set; }

    }
}
