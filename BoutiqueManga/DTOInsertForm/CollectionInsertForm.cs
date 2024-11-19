using System.ComponentModel.DataAnnotations;

namespace BoutiqueManga.API.DTOInsertForm
{
    public class CollectionInsertForm
    {
        /*
        [Id] INT NOT NULL PRIMARY KEY, 
        [Image] NTEXT NOT NULL, 
        [Title] NVARCHAR (250) NOT NULL,
        [Author] NVARCHAR(250) NOT NULL, 
        [Price] DECIMAL(10, 2) NOT NULL,
        [PublishedDate] DATE NOT NULL
        */
        [Required]
        public string Image { get; set; } = string.Empty;
        [Required]
        [MaxLength(250)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(250)]
        public string Author { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
    }
}
