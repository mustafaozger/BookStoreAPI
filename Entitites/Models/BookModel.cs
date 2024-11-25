using System.ComponentModel.DataAnnotations;

namespace Entitites.Models
{
    public class BookModel
    {
        [Key]
        public int bookId { get; set; }
        public String bookName { get; set; }
        public int bookPrice { get; set; }  
           
    }
}