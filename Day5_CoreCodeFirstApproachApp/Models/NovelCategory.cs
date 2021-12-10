namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class NovelCategory
    {
        //public int NovelCategoryId {  get; set; }
        public int NovelId { get; set; }
        public Novel Novel {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category {  get; set; }
    }
}
