using System.Reflection;
using System.Windows;

namespace BrowserTest
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PropertyInfo activeXProp = Browser.GetType().GetProperty("ActiveXInstance", BindingFlags.Instance | BindingFlags.NonPublic);
            object activeX = activeXProp.GetValue(Browser, null);
            activeX.GetType().GetProperty("Silent").SetValue(activeX, true);
        }
    }
}
