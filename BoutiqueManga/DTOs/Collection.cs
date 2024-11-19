using BoutiqueManga.DAL.Entities;

namespace BoutiqueManga.API.DTOs
{
    public class Collection
    {
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
