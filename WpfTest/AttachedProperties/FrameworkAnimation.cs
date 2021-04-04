using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCore;

namespace WpfTest
{
    public class FadeIn : FrameworkAttachedProperty<FadeIn>
    {
        protected override void DoAction(FrameworkElement element, bool value)
        {
            if (value)
                element.FadeInElement(1);
        }
    }
    public class FadeOut : FrameworkAttachedProperty<FadeOut>
    {
        protected override void DoAction(FrameworkElement element, bool value)
        {
            if (value)
                element.FadeOutElement(1);
        }
    }
    public class SlideUpAndFadeOut : FrameworkAttachedProperty<SlideUpAndFadeOut>
    {
        protected async override void DoAction(FrameworkElement element, bool value)
        {
            if (value)
            {
                await element.SlideUpAndFadeOut(1, element.ActualHeight, element.Margin);
            }
        }
    }
    public class SlideDownAndFadeIn:FrameworkAttachedProperty<SlideDownAndFadeIn>
    {
        protected async override void DoAction(FrameworkElement element, bool value)
        {
            if (value)
                await element.SlideDownAndFadeIn(1, element.ActualHeight, element.Margin);
        }
    }
}
