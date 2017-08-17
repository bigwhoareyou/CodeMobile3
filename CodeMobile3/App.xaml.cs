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
            //tp.Children.Add(np);

            var cp = new CarouselPage();
            cp.Children.Add(new MyPage1());
            cp.Children.Add(new MyPage2());
            cp.Children.Add(new MyPage3());

            var mp = new MasterDetailPage();
            mp.Master = new MenuPage();
            mp.Detail = np;

            MainPage = mp;
        }

        public App(string path) : this()
        {
            Helpers.Settings.Path = path;
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
