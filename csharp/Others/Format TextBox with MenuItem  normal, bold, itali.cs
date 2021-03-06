Format TextBox with MenuItem: normal, bold, italic

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="300" Width="500">
    <DockPanel LastChildFill="True">
        <Menu DockPanel.Dock="Top">
            <MenuItem Header="_Edit">
                <MenuItem Header="Cu_t" Command="ApplicationCommands.Cut" />
                <MenuItem Header="_Copy" Command="ApplicationCommands.Copy" />
                <MenuItem Header="_Paste" Command="ApplicationCommands.Paste"/>
                <Separator/>
                <MenuItem Click="SelectAll_Click" Header="_Select All" />
                <MenuItem Click="Clear_Click" Header="_Clear" />
            </MenuItem>
            <MenuItem Header="_Format">
                <MenuItem Click="TextStyle_Click" Header="_Normal" Name="miNormal" />
                <MenuItem Click="TextStyle_Click" FontWeight="Bold" Header="_Bold" Name="miBold" />
                <MenuItem Click="TextStyle_Click" FontStyle="Italic" Header="_Italic" Name="miItalic" />
            </MenuItem>
        </Menu>
        <TextBox Name="txtTextBox" TextWrapping="Wrap">
            text
        </TextBox>
    </DockPanel>
</Window>

//File:Window.xaml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtTextBox.Clear();
        }
        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            txtTextBox.SelectAll();
        }
        private void TextStyle_Click(object sender, RoutedEventArgs e)
        {
            if (sender == miNormal)
            {
                txtTextBox.FontWeight = FontWeights.Normal;
                txtTextBox.FontStyle = FontStyles.Normal;
            }
            else if (sender == miBold)
            {
                txtTextBox.FontWeight = FontWeights.Bold;
            }
            else if (sender == miItalic)
            {
                txtTextBox.FontStyle = FontStyles.Italic;
            }
        }
    }
}

