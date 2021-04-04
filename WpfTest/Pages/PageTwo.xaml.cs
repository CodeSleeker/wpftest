using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfCore;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for PageTwo.xaml
    /// </summary>
    public partial class PageTwo : BasePage<PageTwoViewModel>
    {
        public PageTwo()
        {
            InitializeComponent();
        }
        public PageTwo(PageTwoViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            this.SlideSeconds = 1;
            this.LoadAnimation = WpfCore.PageEnum.SlideAndFadeInFromTop;
            this.UnLoadAnimation = WpfCore.PageEnum.SlideAndFadeOutToBottom;
        }
    }
}
