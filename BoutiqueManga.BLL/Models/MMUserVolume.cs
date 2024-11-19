using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.BLL.Models
{
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
