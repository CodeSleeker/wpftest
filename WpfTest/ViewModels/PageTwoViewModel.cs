using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfCore;

namespace WpfTest
{
    public class PageTwoViewModel : BaseViewModel
    {
        public ICommand FadeInClick { get; set; }
        public ICommand FadeOutClick { get; set; }
        public ICommand SlideUpClick { get; set; }
        public ICommand SlideDownClick { get; set; }
        public bool _FadeIn;
        public bool FadeIn { get { return _FadeIn; } set { _FadeIn = value; OnPropertyChanged(); } }
        public bool _FadeOut;
        public bool FadeOut { get { return _FadeOut; } set { _FadeOut = value; OnPropertyChanged(); } }
        public bool _SlideUp;
        public bool SlideUp { get { return _SlideUp; } set { _SlideUp = value; OnPropertyChanged(); } }
        public bool _SlideDown;
        public bool SlideDown { get { return _SlideDown; } set { _SlideDown = value; OnPropertyChanged(); } }
        public PageTwoViewModel()
        {
            FadeInClick = new RelayCommand(() =>
            {
                FadeIn = true;
            });
            FadeOutClick = new RelayCommand(() =>
            {
                FadeOut = true;
            });
            SlideUpClick = new RelayCommand(() =>
            {
                SlideUp = true;
            });
            SlideDownClick = new RelayCommand(() =>
            {
                SlideDown = true;
            });
        }
    }
}
