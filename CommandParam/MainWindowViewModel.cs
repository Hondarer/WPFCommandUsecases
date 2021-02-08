using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace CommandParam
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int int1;

        public int Int1
        {
            get
            {
                return int1;
            }
            set
            {
                if (int1 != value)
                {
                    int1 = value;
                    Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        if (PropertyChanged != null)
                        {
                            PropertyChanged(this, new PropertyChangedEventArgs("Int1"));
                        }
                    }));
                }
            }
        }

        private readonly Timer timer;

        public MainWindowViewModel()
        {
            TimerCallback timerDelegate = new TimerCallback(Timer_Tick);
            timer = new Timer(timerDelegate, this, 0, 1000);
        }

        void Timer_Tick(object sender)
        {
            Int1++;
            if (Int1 == 10)
            {
                Int1 = 0;
            }
        }
    }
}
