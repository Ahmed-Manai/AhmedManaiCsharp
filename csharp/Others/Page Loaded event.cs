Page Loaded event

<Page       x:Class="WpfApplication1.StartPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"

      Loaded="Init" />
//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApplication1
{
    public partial class StartPage : Page
    {
        TextBlock txtElement;
        StackPanel rootPanel;
        Button aButton;
        void Init(object sender, EventArgs args)
        {
            rootPanel = new StackPanel();
            txtElement = new TextBlock();
            aButton = new Button();
            aButton.Content = "Press me";
    
            rootPanel.Children.Add(txtElement);
            rootPanel.Children.Add(aButton);
        }
    }
}

