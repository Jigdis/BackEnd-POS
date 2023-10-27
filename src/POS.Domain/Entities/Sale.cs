using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int State { get; set; }
        public int AuditCreateUser { get; set; }
        public DateTime AuditCreateDate { get; set; }
        public int? AuditUpdateUser { get; set; }
        public DateTime? AuditUpdateDate { get; set; }
        public int? AuditDeleteUser { get; set; }
        public DateTime? AuditDeleteDate { get; set; }

        [ForeignKey("ClientId")]
        public Clients Client { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }
        public ICollection<SaleDetail> SaleDetails { get; set; }
    }

}
