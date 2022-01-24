using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinRTComponent
{
    public sealed partial class TestControl : UserControl
    {

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(TestControl), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty BgColorProperty =
            DependencyProperty.Register(nameof(BackgroundColor), typeof(string), typeof(TestControl), new PropertyMetadata(string.Empty));

        public TestControl()
        {
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public string BackgroundColor
        {
            get { return (string)GetValue(BgColorProperty); }
            set { SetValue(BgColorProperty, value); }
        }
    }
}
