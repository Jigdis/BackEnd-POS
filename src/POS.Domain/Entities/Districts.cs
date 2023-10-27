using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Districts")]
    public class Districts
    {
        [Key]
        public int DistrictId { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int State { get; set; }

        [ForeignKey("ProvinceId")]
        public Provinces Province { get; set; }
        public ICollection<BranchOffice> BranchOffices { get; set; }
        public ICollection<Business> Businesses { get; set; }
    }
}
