using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Picture { get; set; }

        [MaxLength(100)]
        public string ProfileName { get; set; }

        [MaxLength(255)]
        public string ProfilePicture { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public int BranchOfficeId { get; set; }

        public int? State { get; set; }

        [Required]
        public int AuditCreateUser { get; set; }

        [Required]
        public DateTime AuditCreateDate { get; set; }
        public int? AuditUpdateUser { get; set; }
        public DateTime? AuditUpdateDate { get; set; }
        public int? AuditDeleteUser { get; set; }
        public DateTime? AuditDeleteDate { get; set; }

        [ForeignKey("RoleId")]
        public Roles Role { get; set; }

        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<UserBranchOffice> UserBranchOffices { get; set; }
    }
}
