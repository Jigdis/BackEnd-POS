using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int State { get; set; }
        public int BranchOfficeId { get; set; }

        [ForeignKey("RoleId")]
        public Roles Role { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }

        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }
    }

}
