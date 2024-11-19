using System.ComponentModel.DataAnnotations;

namespace BoutiqueManga.API.DTOInsertForm
{
    public class VolumeInsertForm
    {
        /*
        [ISBN] NVARCHAR(13) NOT NULL PRIMARY KEY, 
        [VolNumber] INT NOT NULL, 
        [CoverImage] NTEXT NOT NULL, 
        [Stock] INT NOT NULL, 
        [EditorId] INT NOT NULL,
        [CollectionId] INT NOT NULL,
        CONSTRAINT FK_Edition FOREIGN KEY ([EditorId]) REFERENCES [Editor] (Id),
        CONSTRAINT FK_CollectionId FOREIGN KEY ([CollectionId]) REFERENCES [Collection] (Id)
        */
        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; } = string.Empty;
        [Required]
        public int VolNumber { get; set; }
        [Required]
        public string CoverImage { get; set; } = string.Empty;
        [Required]
        public int Stock { get; set; }
        [Required]
        public int EditorId { get; set; }
        [Required]
        public int CollectionId { get; set; }
    }
}
