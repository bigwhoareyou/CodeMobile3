using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            menuButton1.Clicked += MenuButton_Clicked;
            menuButton2.Clicked += MenuButton_Clicked;
            menuButton3.Clicked += MenuButton_Clicked;
            menuButton4.Clicked += MenuButton_Clicked;
        }

        void MenuButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            
            if (sender == menuButton1)
            {
                var np = new NavigationPage(new NavPage1());
                mp.Detail = np;
            }
            else if (sender == menuButton2)
            {
				var tp = new TabbedPage();
				tp.Children.Add(new MyPage1());
				tp.Children.Add(new MyPage2());
				tp.Children.Add(new MyPage3());

                var np = new NavigationPage(tp);
                mp.Detail = np;
            }
			else if (sender == menuButton3)
			{
				var cp = new CarouselPage();
				cp.Children.Add(new MyPage1());
				cp.Children.Add(new MyPage2());
				cp.Children.Add(new MyPage3());

                var np = new NavigationPage(cp);
                mp.Detail = np;
			}
			else if (sender == menuButton4)
			{
                var np = new NavigationPage(new Page1());
                mp.Detail = np;
			}

            mp.IsPresented = false;
        }

    }
}
