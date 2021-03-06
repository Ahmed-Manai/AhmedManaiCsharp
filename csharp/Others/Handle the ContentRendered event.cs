Handle the ContentRendered event

<Window x:Class="ContentRendered.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ContentRendered" Height="360" Width="450" ContentRendered="OnContentRendered">
    <Grid>
        
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


namespace ContentRendered
{
    public partial class Window1 : System.Windows.Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void OnContentRendered(object sender, EventArgs e)
        {
            MessageBox.Show("Content Rendered Event Fired!");
        }

    }
}

