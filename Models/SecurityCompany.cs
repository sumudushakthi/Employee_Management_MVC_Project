namespace EmployeeManagement.Models
{
    public class SecurityCompany
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ContactPerson { get; set; }
        public int ContactNumber { get; set; }
        public char UserName { get; set; }
        public char Password { get; set; }
    }
}
