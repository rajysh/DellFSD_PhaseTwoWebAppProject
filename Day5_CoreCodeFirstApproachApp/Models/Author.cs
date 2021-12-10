using System.Collections.Generic;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public AuthorBiography AuthorBiography { get; set; }
    }
}
