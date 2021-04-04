using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfCore;
using static WpfTest.ServiceExtensions;

namespace WpfTest
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand PageOneClick { get; set; }
        public ICommand PageTwoClick { get; set; }
        public MainWindowViewModel()
        {
            PageOneClick = new RelayCommand(() =>
            {
                appViewModel.NavigateTo(PageEnum.PageOne);
            });
            PageTwoClick = new RelayCommand(() =>
            {
                appViewModel.NavigateTo(PageEnum.PageTwo);
            });
        }
    }
}
