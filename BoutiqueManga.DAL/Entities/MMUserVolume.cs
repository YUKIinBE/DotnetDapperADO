using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.DAL.Entities
{
    /*
    [Id] INT NOT NULL PRIMARY KEY, 
    [PurchaseDate] DATE NOT NULL, 
    [Quantity] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    [VolumeISBN] NVARCHAR(13) NOT NULL,
    CONSTRAINT FK_UserId FOREIGN KEY ([UserId]) REFERENCES [User] (Id),
    CONSTRAINT FK_VolumeId FOREIGN KEY ([VolumeISBN]) REFERENCES [Volume] (ISBN)
    */
    public class MMUserVolume
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public string VolumeISBN { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
