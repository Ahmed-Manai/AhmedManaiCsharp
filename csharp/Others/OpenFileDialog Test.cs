OpenFileDialog Test

<Window x:Class="Windows.OpenFileTest"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="OpenFileTest" Height="420" Width="600" 
    >
  <DockPanel Margin="6">
    <Button DockPanel.Dock="Top" Click="cmdOpen_Click">Open</Button>
    <ListBox Name="lstFiles"></ListBox>
  </DockPanel>
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
using Microsoft.Win32;

namespace Windows
{
    public partial class OpenFileTest : System.Windows.Window
    {
        public OpenFileTest()
        {
            InitializeComponent();
        }

        private void cmdOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;

            if (myDialog.ShowDialog() == true)
            {
                lstFiles.Items.Clear();
                foreach (string file in myDialog.FileNames)
                {
                    lstFiles.Items.Add(file);
                }                
            }
        }
    }
}

