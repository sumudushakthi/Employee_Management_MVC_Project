using NuGet.Packaging.Signing;

namespace EmployeeManagement.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public string location { get; set; }
        public int Year {  get; set; }
        public char Month { get; set; }
        public int Day { get; set; }
        public char SId { get; set; }
        public string Designation { get; set; }
        public string EmployeeName { get; set; }
        public DateTime ArrivalDate {  get; set; }
        public DateTime DepartureDate { get; set; }
        public string Duration { get; set; }
        public string Penalty { get; set; }
        public string Remarks { get; set; }

    }
}
