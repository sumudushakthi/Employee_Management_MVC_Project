namespace EmployeeManagement.Models
{
    public class Approval
    {
        public int Id { get; set; }
        public char location { get; set; }
        public int Year { get; set; }
        public char Month { get; set; }
        public char SId { get; set; }
        public string EmployeeName { get; set; }
        public char Count {  get; set; }
        public char SpecialDetails {  get; set; }
    }
}
