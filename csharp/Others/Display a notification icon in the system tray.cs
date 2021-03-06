Display a notification icon in the system tray

<Window x:Class="NotificationIconSample.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="NotificationIconSample" Height="250" Width="360">
    <Grid>
      <Button Click="click">Click</Button>
    </Grid>
</Window>

//File:Window.xaml.cs
namespace NotificationIconSample
{
    using System;
    using System.Windows;
    using System.Windows.Forms; 
    using System.Drawing;
    public partial class MainWindow : Window
    {
        NotifyIcon notifyIcon;

        public MainWindow()
        {
            InitializeComponent();
        }

        void click(object sender, RoutedEventArgs e)
        {
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.BalloonTipText = "Hello, NotifyIcon!";
            this.notifyIcon.Text = "Hello, NotifyIcon!";
            this.notifyIcon.Icon = new System.Drawing.Icon("NotifyIcon.ico");
            this.notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(1000);
        }
    }
}

