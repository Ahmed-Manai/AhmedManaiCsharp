Digital Clock

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
        xmlns:src="clr-namespace:MyNameSpace.DigitalClock"
        Title="Digital Clock"
        SizeToContent="WidthAndHeight">
    <Window.Resources>
        <src:ClockTicker1 x:Key="clock" />
    </Window.Resources>
    <Window.Content>
        <Binding Source="{StaticResource clock}" Path="DateTime" />
    </Window.Content>
</Window>
//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Threading;

namespace MyNameSpace.DigitalClock
{
    public class ClockTicker1 : DependencyObject
    {
        public static DependencyProperty DateTimeProperty = 
                DependencyProperty.Register("DateTime", typeof(DateTime), 
                                            typeof(ClockTicker1));
        
        public DateTime DateTime
        {
            set { SetValue(DateTimeProperty, value); }
            get { return (DateTime) GetValue(DateTimeProperty); }
        }

        public ClockTicker1()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        void TimerOnTick(object sender, EventArgs args)
        {
            DateTime = DateTime.Now;
        }
    }
}

