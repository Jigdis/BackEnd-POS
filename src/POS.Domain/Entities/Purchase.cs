using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    [Table("Purchase")]
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }
        public int ProviderId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int State { get; set; }
        public int AuditCreateUser { get; set; }
        public DateTime AuditCreateDate { get; set; }
        public int? AuditUpdateUser { get; set; }
        public DateTime? AuditUpdateDate { get; set; }
        public int? AuditDeleteUser { get; set; }
        public DateTime? AuditDeleteDate { get; set; }

        [ForeignKey("ProviderId")]
        public Providers Provider { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }

}
