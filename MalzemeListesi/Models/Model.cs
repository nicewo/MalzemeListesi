namespace MalzemeListesi.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Ad { get; set; } = string.Empty;

        public int MarkaId { get; set; }
        public int BirimId { get; set; }
        public int AciklamaId { get; set; }

        // UI tarafı için (opsiyonel)
        public string MarkaAd { get; set; } = string.Empty;
        public string BirimAd { get; set; } = string.Empty;
        public string AciklamaAd { get; set; } = string.Empty;
    }
}
