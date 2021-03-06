Property changed callback

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Window1" Height="360" Width="450">

    <StackPanel>
      <TextBox x:Name="uv" Text="{Binding Path=UserValue, UpdateSourceTrigger=PropertyChanged}" 
               />

    </StackPanel>

</Window>


//File:Window1.xaml.cs
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = this;
        }
        private static void UserValue_PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Window1 window1 = d as Window1;

            if (window1 != null)
            {                
                window1.uv.Foreground = Brushes.SeaGreen;
            }
        }
    }
}

