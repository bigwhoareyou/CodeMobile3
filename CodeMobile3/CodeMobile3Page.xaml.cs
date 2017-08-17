using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class CodeMobile3Page : ContentPage
    {
        public CodeMobile3Page()
        {
            InitializeComponent();


            genderPicker.Items.Add("Male");
            genderPicker.Items.Add("Female");


            myButton.Clicked += MyButton_Clicked;
            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;

            if (Device.RuntimePlatform == "iOS")
            {
                
            }
            else if (Device.RuntimePlatform == "Android")
            {
                
            }
        }

        void MyButton_Clicked(object sender, System.EventArgs e)
        {
            myLabel.Text = myEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = ((int)e.NewValue).ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = ((int)e.NewValue).ToString();
            mySlider.Value = e.NewValue;
        }
    }
}
