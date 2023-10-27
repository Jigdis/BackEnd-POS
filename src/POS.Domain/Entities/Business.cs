using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities
{
    [Table("Business")]
    public class Business
    {
        [Key]
        public int BusinessId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(11)]
        public string Ruc { get; set; }

        [Required]
        [MaxLength(100)]
        public string BusinessName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Logo { get; set; }

        public int DistrictId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Vision { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Mision { get; set; }

        public int State { get; set; }

        [ForeignKey("DistrictId")]
        public Districts District { get; set; }
        public ICollection<BranchOffice> BranchOffices { get; set; }

    }
}
