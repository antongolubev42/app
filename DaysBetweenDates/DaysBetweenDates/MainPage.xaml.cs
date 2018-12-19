using System;

using Xamarin.Forms;

using Xamarin.Forms.Xaml;



namespace DaysBetweenDates

{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage

    {

        public MainPage()

        {

            InitializeComponent();

        }



        void OnDateSelected(object sender, DateChangedEventArgs args)

        {

           Calculate();

        }



        void OnSwitchToggled(object sender, ToggledEventArgs args)

        {

            Calculate();

        }


        //calculate the difference in days

        void Calculate()

        {

            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +

                (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);


            //output result to screen
            resultLabel.Text = String.Format("{0} day{1} between dates",

                                             timeSpan.Days, timeSpan.Days == 1 ? "" : "s");

        }

    }

}