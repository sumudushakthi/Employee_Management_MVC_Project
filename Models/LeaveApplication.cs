using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class LeaveApplication : ApprovalActivity
    {
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        [Required]
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        [Display(Name = "No Of Leave Days")]
        [Required]
        public int NoOfDays { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString ="{0:yyyy/MM/dd}")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Required]
        public DateTime EndDate { get; set; }

        [Display(Name = "Leave Duration")]
        [Required]
        public int DurationId { get; set; }
        public SystemCodeDetail? Duration { get; set; }

        [Display(Name = "Leave Type")]
        [Required]
        public int LeaveTypeId { get; set; }
        public LeaveType? LeaveType { get; set; }

        public string? Attachment { get; set; }

        [Display(Name = "Notes")]
        public string Description { get; set; }

        [Display(Name = "Status")]
        [Required]
        public int StatusId { get; set; }
        public SystemCodeDetail? Status { get; set; }

        [Display(Name = "Approval Notes")]
        public string? ApprovalNotes { get; set; }
    }
}
