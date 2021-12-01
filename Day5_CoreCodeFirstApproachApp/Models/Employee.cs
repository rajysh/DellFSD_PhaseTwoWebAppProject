namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class Employee
    {
        //Scalar Properties
        public int EmployeeId { get; set; }
        public string Name {  get; set; }
        public string Gender {  get; set; }
        //Navigation Properties
        public Company Company {  get; set; }
    }
}
