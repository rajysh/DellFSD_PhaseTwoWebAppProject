using System.Collections.Generic;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class Novel
    {
        public int NovelId {  get; set; }
        public string NovelName {  get; set; }
        public List<NovelCategory> NovelCategories { get; set; }
    }
}
