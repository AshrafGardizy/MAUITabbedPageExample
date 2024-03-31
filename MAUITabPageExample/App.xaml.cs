using MAUITabPageExample.MyTabPages;

namespace MAUITabPageExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedDemoPage();    
        }
    }
}
