using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using WpfCore;

namespace WpfTest
{
    public static class ElementAnimation
    {
        public static async Task SlideUpAndFadeOut(this FrameworkElement element, float seconds, double offset, Thickness margin)
        {
            var sb = new Storyboard();
            StoryboardHelper.SlideToTop(sb, 1, offset, margin);
            StoryboardHelper.FadeOut(sb, 1);
            sb.Begin(element);
            await Task.Delay((int)seconds * 1000);
        }
        public static async Task SlideDownAndFadeIn(this FrameworkElement element, float seconds, double offset, Thickness margin)
        {
            var sb = new Storyboard();
            StoryboardHelper.SlideToBottom(sb, 1, offset, margin);
            StoryboardHelper.FadeIn(sb, 1);
            sb.Begin(element);
            await Task.Delay((int)seconds * 1000);
        }
    }
}
