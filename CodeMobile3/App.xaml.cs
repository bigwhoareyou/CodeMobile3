using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var np = new NavigationPage(new NavPage1());
            np.Title = "Page 4";
            np.Icon = "anchor";

            var tp = new TabbedPage();
            tp.Children.Add(new MyPage1());
            tp.Children.Add(new MyPage2());
            tp.Children.Add(new MyPage3());
            tp.Children.Add(np);

            MainPage = tp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
