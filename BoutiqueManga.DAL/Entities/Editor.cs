using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.DAL.Entities
{
    /*
    [Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(250) NOT NULL
    */
    public class Editor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
