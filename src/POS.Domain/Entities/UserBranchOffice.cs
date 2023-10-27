using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    public class UserBranchOffice
    {
        public int UserBranchOfficeId { get; set; }
        public int UserId { get; set; }
        public int BranchOfficeId { get; set; }
        public int State { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }

        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }
    }

}
