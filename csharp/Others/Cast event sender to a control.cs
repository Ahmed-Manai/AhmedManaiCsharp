Cast event sender to a control

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        x:Class="MyNameSpace.IncludeApplicationDefinition.MyWindow"
        Title="Include Application Definition" 
        SizeToContent="WidthAndHeight" 
        ResizeMode="CanMinimize">
    <Button HorizontalAlignment="Center" VerticalAlignment="Center" Margin="1.5in" Click="ButtonOnClick">
        Click
    </Button>
</Window>

//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyNameSpace.IncludeApplicationDefinition
{
    public partial class MyWindow : Window
    {
        public MyWindow()
        {
            InitializeComponent();
        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Content + "'clicked.");
        }
    }
}

