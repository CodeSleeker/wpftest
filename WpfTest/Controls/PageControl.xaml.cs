using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfCore;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for PageControl.xaml
    /// </summary>
    public partial class PageControl : UserControl
    {
        public PageControl()
        {
            InitializeComponent();
        }
        public PageEnum CurrentPage
        {
            get { return (PageEnum)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }
        public BaseViewModel CurrentPageViewModel
        {
            get { return (BaseViewModel)GetValue(CurrentPageViewModelProperty); }
            set { SetValue(CurrentPageViewModelProperty, value); }
        }

        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage),
                typeof(PageEnum), typeof(PageControl),
                new UIPropertyMetadata(default(PageEnum), null, CurrentPagePropertyChanged));

        public static readonly DependencyProperty CurrentPageViewModelProperty =
            DependencyProperty.Register(nameof(CurrentPageViewModel),
                typeof(BaseViewModel), typeof(PageControl),
                new UIPropertyMetadata());

        public static object CurrentPagePropertyChanged(DependencyObject d, object value)
        {
            var currentPage = (PageEnum)value;
            var currentPageViewModel = d.GetValue(CurrentPageViewModelProperty);

            var newPageFrame = (d as PageControl).NewPage;
            var oldPageFrame = (d as PageControl).OldPage;

            var oldPageContent = newPageFrame.Content;
            newPageFrame.Content = null;
            oldPageFrame.Content = oldPageContent;

            if(oldPageContent is BasePage oldPage)
            {
                oldPage.WillAnimateOut = true;
                Task.Delay((int)oldPage.SlideSeconds * 1000).ContinueWith((t) =>
                {
                    Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
                });
            }
            newPageFrame.Content = currentPage.ToPage(currentPageViewModel);
            return value;
        }
    }
}
