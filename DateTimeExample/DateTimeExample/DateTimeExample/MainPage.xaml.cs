using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DateTimeExample
{
    public partial class MainPage : ContentPage
    {

        DateTime _time;

        public MainPage()
        {
            InitializeComponent();
           
        }


        void TimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {

            if(args.PropertyName == "Time")
            {
                _time = DateTime.Today + _timePicker.Time;

                if(_time <DateTime.Now)
                {
                    _time += TimeSpan.FromDays(1);
                }

            }

        }


    }
}
