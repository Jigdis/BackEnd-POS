using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Provinces")]
    public class Provinces
    {
        [Key]
        public int ProvinceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public int State { get; set; }

        [ForeignKey("DepartmentId")]
        public Departments Department { get; set; }
        public ICollection<Districts> Districts { get; set; }

    }
}
