using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities
{
    [Table("BranchOffice")]
    public class BranchOffice
    {
        [Key]
        public int BranchOfficeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        public int BusinessId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public int DistrictId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Phone { get; set; }

        public int State { get; set; }

        [ForeignKey("BusinessId")]
        public Business Business { get; set; }

        [ForeignKey("DistrictId")]
        public Districts District { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<UserBranchOffice> UserBranchOffices { get; set; }
    }
}
