using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("DocumentTypes")]
    public class DocumentTypes
    {
        [Key]
        public int DocumentTypeId { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(5)]
        public string Abbreviation { get; set; }

        public int? State { get; set; }
        public ICollection<Clients> Clients { get; set; }
        public ICollection<Providers> Providers { get; set; }


    }
}
