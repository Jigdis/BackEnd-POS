﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Providers")]
    public class Providers
    {
        [Key]
        public int ProviderId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int DocumentTypeId { get; set; }

        [MaxLength(20)]
        public string DocumentNumber { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

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

        [ForeignKey("DocumentTypeId")]
        public DocumentTypes DocumentType { get; set; }
        public ICollection<Products> Products { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}