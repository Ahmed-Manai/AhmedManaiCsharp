Window Closing and Closed event

<Window x:Class="ApplicationShutdownSample.ChildWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Application Shutdown Sample" Closing="ChildWindow_Closing" Closed="ChildWindow_Closed">
    <Grid>
    </Grid>
</Window>

//File:Window.xaml.cs
using System;
using System.ComponentModel;
using System.Windows;

namespace ApplicationShutdownSample
{
    public partial class ChildWindow : Window
    {
        public ChildWindow()
        {
            InitializeComponent();
        }

        void ChildWindow_Closing(object sender, CancelEventArgs e)
        {
            Console.WriteLine("Closing");
            MessageBoxResult result = MessageBox.Show("Allow Shutdown?", "Application Shutdown Sample", MessageBoxButton.YesNo, MessageBoxImage.Question);
            e.Cancel = (result == MessageBoxResult.No);
        }

        void ChildWindow_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Closed");
        }
    }
}

