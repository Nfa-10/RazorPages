namespace RazorCRUD.Models
{
    public class BookModel
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public int Edition { get; set; }
        public float Price { get; set; }
        public DateTime dateOfPublishing { get; set; }   
        public int AuthorID { get; set; }   
    }
}
