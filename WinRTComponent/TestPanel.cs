using Microsoft.UI.Xaml.Controls;
using Windows.Foundation;

namespace WinRTComponent
{
    public sealed class TestPanel : StackPanel
    {
        public bool Food { get; set; }

        public TestPanel() : this(false) { }
        public TestPanel(bool x) { Food = x; }
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (var child in Children)
            {
                child.Measure(new Size(160, 50));
            }

            return new Size(330, 500);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            int x = 0, y = 0;
            foreach (var child in Children)
            {
                child.Arrange(new Rect(x, y, child.DesiredSize.Width, child.DesiredSize.Height));
                x = (x + 165) % 330;
                if (x == 0)
                {
                    y += 50;
                }
            }

            return new Size(330, 500);
        }
    }
}
