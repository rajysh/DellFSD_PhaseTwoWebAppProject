using System;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name {  get; set; }
        public string Gender {  get; set; }
        public string City {  get; set; }
        public string Country {  get; set; }
        public DateTime DateOfBirth {  get; set; }
    }
}
