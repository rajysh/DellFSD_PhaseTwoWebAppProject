namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class Book
    {
        public int BookId {  get; set; }
        public string Title {  get; set; }
        public double Price {  get; set; }
        public int AuthorId {  get; set; }
        public Author Author {  get; set; }
    }
}
