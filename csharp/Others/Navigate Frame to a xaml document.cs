Navigate Frame to a xaml document

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="FrameWindowSample.SDKViewerWindow"
    Title="SDK Viewer" Width="400" Height="550">
    <StackPanel Margin="8,8,8,8">
        <TextBlock>
            <Hyperlink Name="homeHyperlink" Click="homeHyperlink_Click">Home</Hyperlink>
        </TextBlock>
        <Frame Name="sdkFrame" Background="WhiteSmoke" Source="SDKFramePage.xaml" NavigationUIVisibility="Visible" />
       
    </StackPanel>
</Window>

//File:Window.xaml.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrameWindowSample
{
    public partial class SDKViewerWindow : Window
    {

        public SDKViewerWindow()
        {
            InitializeComponent();
        }
        
        void homeHyperlink_Click(object sender, RoutedEventArgs e) {
            this.sdkFrame.Navigate(new Uri("SDKFramePage.xaml", UriKind.Relative));
        }

    }
}

