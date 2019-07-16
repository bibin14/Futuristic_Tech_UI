using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Futuristic_Tech_UI
{
    /// <summary>
    /// Interaction logic for ucDigitalClock.xaml
    /// </summary>
    public partial class ucDigitalClock : UserControl
    {
        public ucDigitalClock()
        {
            InitializeComponent();

            this.SetTime(); 
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(async (object s, EventArgs a) =>
            {
                this.SetTime(); 
            });
            timer.Start();
        }

        void SetTime()
        {
            this.txtTime.Text = DateTime.Now.ToString("HH:mm");
            this.txtTimeSecond.Text = DateTime.Now.ToString("ss");
            this.txtTimeAMPM.Text = DateTime.Now.ToString("tt");
        }

    }
}
