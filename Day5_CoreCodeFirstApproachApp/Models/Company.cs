using System.Collections.Generic;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class Company
    {
        //Scalar Properties
        public int CompanyId {  get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        //Navigation Properties
        public ICollection<Employee> Employee {  get; set; }
    }
}
