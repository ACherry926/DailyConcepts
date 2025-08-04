using System.ComponentModel.DataAnnotations;

namespace Day29Concepts.Model
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Add Title Property")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
