using Onlineshop.Models;

namespace Onlineshop.ViewModels
{
    public class HomePageBannersViewModel
    {
        public List<BannerItem> Sliders { get; set; }
        public BannerItem? MiddleLeftBanner { get; set; }
        public BannerItem? MiddleRightBanner { get; set; }
        public BannerItem? BottomLeftBanner { get; set; }
        public BannerItem? BottomRightBanner { get; set; }
    }



}
