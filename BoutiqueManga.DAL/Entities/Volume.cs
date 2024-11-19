using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.DAL.Entities
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
    public class Volume
    {
        public string ISBN { get; set; } = string.Empty;
        public int VolNumber { get; set; }
        public string CoverImage { get; set; } = string.Empty;
        public int Stock { get; set; }
        public int EditorId { get; set; }
        public int CollectionId { get; set; }
    }
}
