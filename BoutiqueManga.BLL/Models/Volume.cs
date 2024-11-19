using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.BLL.Models
{
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
