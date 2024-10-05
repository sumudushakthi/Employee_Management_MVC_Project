using System.ComponentModel;

namespace EmployeeManagement.Models
{
    public class UserActivity
    {
        [DisplayName("Created By")]
        public string? CreateByID { get; set; }
        [DisplayName("Created By")]
        public ApplicationUser CreatedBy { get; set; }
        [DisplayName("Created On")]
        public DateTime CreateOn { get; set; }
        [DisplayName("Modified By")]
        public string? ModifiedByID { get; set; }
        [DisplayName("Modified By")]
        public ApplicationUser ModifiedBy { get; set; }
        [DisplayName("Modified On")]
        public DateTime CModifiedOn { get; set; }
    }

    public class ApprovalActivity:UserActivity
    {
        [DisplayName("Approved By")]
        public string? ApprovedByID { get; set; }
        [DisplayName("Approved By")]
        public ApplicationUser ApprovedBy { get; set; }
        [DisplayName("Approved On")]
        public DateTime ApprovedOn { get; set; }
        
    }
}
