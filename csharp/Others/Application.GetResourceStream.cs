Application.GetResourceStream

<Window x:Class="BinaryResources.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="BinaryResources" Height="240" Width="240">
    <Grid>
      <Image Source="c:/image.gif" />
    </Grid>
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
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Resources;
using System.Collections;
using System.Windows.Resources;

namespace BinaryResources
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();

            Uri resourcePath = new Uri("file:///c:/image.gif", UriKind.Relative);
            StreamResourceInfo ri = Application.GetResourceStream(resourcePath);
            Stream data = ri.Stream;

            // data;
        }
    }
}

