using System.ComponentModel;

namespace EmployeeManagement.Models
{
    public class ApprovalEntry
    {
        public int Id { get; set; }
        [DisplayName("Record Id")]
        public int RecordId { get; set; } //1
        [DisplayName("Document Type")]
        public int DocumentTypeId { get; set; } //leave-application
        public SystemCodeDetail DocumentType { get; set; }
        [DisplayName("Sequence No")]
        public int SequenceNo { get; set; } //1,2,3,4,5,6(Approval)
        [DisplayName("Approver Name")]
        public string ApproverId { get; set; }
        public ApplicationUser Approver { get; set; }

        [DisplayName("Status")]
        public int StatusId { get; set; } // status of document
        public SystemCodeDetail Status { get; set; }
        [DisplayName("Date Sent For Approval")]
        public DateTime DateSentForApproval { get; set; } //Date sent for Approval 
        [DisplayName("Last Modified On")]
        public DateTime LastModifiedOn { get; set; }  //the action of approvar  
        [DisplayName("Last Modified By")]
        public string LastModifiedById {  get; set; }
        public ApplicationUser LastModifiedBy { get; set; }
        [DisplayName("Comments")]
        public string Comments { get; set; }

        [DisplayName("Controller Name")]
        public string ControllerName { get; set; }
    }
}
