using System;

namespace AspNetCoreViewModelSample.Models.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public SearchInputModel InputModel { get; set; }
    }
}
