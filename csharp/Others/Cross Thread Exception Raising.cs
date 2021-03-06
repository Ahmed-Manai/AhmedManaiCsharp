Cross Thread Exception Raising

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="WpfApplication1.SecondaryUiThreadWindow"
  Height="240" Width="500" Closed="SecondaryUiThreadWindow_Closed">
  <Button Click="r">Raise an Exception on the Secondary UI Thread</Button>

</Window>
//File:Window.xaml.cs
using System; 
using System.Threading;
using System.Windows; 
using System.Windows.Threading;

namespace WpfApplication1
{
    public partial class SecondaryUiThreadWindow : Window
    {
        public SecondaryUiThreadWindow()
        {
            InitializeComponent();

            this.Title = Thread.CurrentThread.ManagedThreadId+"";
        }
        void r(object sender, RoutedEventArgs e)
        {
            throw new Exception(Dispatcher.CurrentDispatcher.Thread.ManagedThreadId+"");
        }
        void SecondaryUiThreadWindow_Closed(object sender, EventArgs e)
        {
            Dispatcher.CurrentDispatcher.InvokeShutdown();
        }
    }
}

