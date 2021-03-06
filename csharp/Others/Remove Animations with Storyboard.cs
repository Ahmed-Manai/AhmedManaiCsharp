Remove Animations with Storyboard

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="" Height="440" Width="580">
  <Window.Resources>
    <Storyboard x:Key="Storyboard1">
      <ParallelTimeline>
        <DoubleAnimation x:Name="Animation1" Storyboard.TargetProperty="Width" From="160" To="60"
          AutoReverse="True" RepeatBehavior="Forever" />
        <DoubleAnimation Storyboard.TargetProperty="Opacity" To="0.5" AutoReverse="True" RepeatBehavior="Forever" />
      </ParallelTimeline>
    </Storyboard>
  </Window.Resources>

  <UniformGrid>
    <Button Content="Method 4" Click="Button4_Click" Loaded="Button4_Loaded" />
  </UniformGrid>
</Window>
//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private Storyboard method4Storyboard;

        private void Button4_Loaded(object sender, RoutedEventArgs e)
        {
            method4Storyboard = TryFindResource("Storyboard1") as Storyboard;
            method4Storyboard.Begin(sender as FrameworkElement, true);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (method4Storyboard != null)
            {
                method4Storyboard.Remove(sender as FrameworkElement);
            }
        }
     
    }
}

