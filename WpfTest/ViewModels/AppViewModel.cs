using WpfCore;

namespace WpfTest
{
    public class AppViewModel:BaseViewModel
    {
        public PageEnum CurrentPage { get; set; }
        public BaseViewModel CurrentPageViewModel { get; set; }
        public void NavigateTo(PageEnum page, BaseViewModel viewModel = null)
        {
            CurrentPageViewModel = viewModel;
            CurrentPage = page;
            OnPropertyChanged(nameof(CurrentPage));
        }
    }
}
