using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCore;

namespace WpfTest
{
    public static class PageConverter
    {
        public static BasePage ToPage(this PageEnum page, object viewModel = null)
        {
            switch (page)
            {
                case PageEnum.PageOne:
                    return new PageOne(viewModel as PageOneViewModel);
                case PageEnum.PageTwo:
                    return new PageTwo(viewModel as PageTwoViewModel);
                default:
                    return null;
            }
        }
    }
}
