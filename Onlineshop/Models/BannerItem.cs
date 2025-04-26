namespace Onlineshop.Models
{
    public class BannerItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageName { get; set; }
        public string? Link { get; set; }
        public int? Priority { get; set; }

        // به جای enum مستقیم string ذخیره می‌کنیم
        public string? Position { get; set; } // "Slider", "RightBanner", "LeftBanner"
    }


}
