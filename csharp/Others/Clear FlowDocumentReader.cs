Clear FlowDocumentReader

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="FlowDocReader Load/Save Sample" Width="600" Height="400">
  <StackPanel>
    <FlowDocumentReader Name="FlowDocRdr" Grid.Row="1"/>
  </StackPanel>
</Window>

//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Windows.Markup;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            FlowDocRdr.Document = null; 
        }
    }
}

