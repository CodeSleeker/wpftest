using static WpfTest.ServiceExtensions;
namespace WpfTest
{
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();
        public static AppViewModel AppViewModel => appViewModel;
    }
}
