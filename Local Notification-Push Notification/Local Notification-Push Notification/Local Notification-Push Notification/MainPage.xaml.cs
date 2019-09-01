using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Local_Notification_Push_Notification
{
    public partial class MainPage : ContentPage
    {
        DateTime _time;

        public MainPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {
            if (_switch.IsToggled && DateTime.Now >= _time)
            {
                _switch.IsToggled = false;

                CrossLocalNotifications.Current.Show(_entry.Text, _editor.Text);


            }

            return true;
        }

        void TimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {

            if (args.PropertyName == "Time")
            {
                SetTriggerTime();

            }

        }


        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
        }


        void SetTriggerTime()
        {
            _time = DateTime.Today + _timePicker.Time;

            if (_time < DateTime.Now)
            {
                _time += TimeSpan.FromDays(1);
            }
        }
    }
}
