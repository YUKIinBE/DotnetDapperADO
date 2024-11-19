namespace BoutiqueManga.API.DTOs
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
