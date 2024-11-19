using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.DAL.Entities
{
    /*
    [Id] INT NOT NULL PRIMARY KEY, 
    [Image] NTEXT NOT NULL, 
    [Title] NVARCHAR (250) NOT NULL,
    [Author] NVARCHAR(250) NOT NULL, 
    [Price] DECIMAL(10, 2) NOT NULL,
    [PublishedDate] DATE NOT NULL
    */
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
