using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class MyView : ContentView
    {
        public MyView()
        {
            InitializeComponent();

			saveButton.Clicked += SaveButton_Clicked;

			nameEntry.Text = Helpers.Settings.Name;
			ageEntry.Text = Helpers.Settings.Age.ToString();
			pathEditor.Text = Helpers.Settings.Path;
        }

		void SaveButton_Clicked(object sender, EventArgs e)
		{
			Helpers.Settings.Name = nameEntry.Text;
			Helpers.Settings.Age = int.Parse(ageEntry.Text);

			//Page.DisplayAlert("", "บันทึกสำเร็จแล้ว", "OK");
            Application.Current.MainPage.DisplayAlert("", "บันทึกสำเร็จแล้ว", "OK");
		}
    }
}
