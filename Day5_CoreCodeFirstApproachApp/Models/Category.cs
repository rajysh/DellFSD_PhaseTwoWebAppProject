using System.Collections.Generic;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName {  get; set; }

        public List<NovelCategory> NovelCategories {  get; set; }
    }
}
