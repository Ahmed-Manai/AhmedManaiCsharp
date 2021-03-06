Set interval and event handler for DispatcherTimer

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="KeyboardInput" Height="320" Width="450">
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
using System.Windows.Threading;
using System.Diagnostics;


namespace WpfApplication1
{
    public partial class Window1 : System.Windows.Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        public Window1()
        {
            InitializeComponent();
            dt.Interval = TimeSpan.FromSeconds(0.5);
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
         
            if ((Keyboard.Modifiers & ModifierKeys.Control) != 0)
            {
                Console.WriteLine("ModifierKeys.Control");
            }
            bool homeKeyPressed = Keyboard.IsKeyDown(Key.Home);
            Debug.WriteLine("Home pressed: " + homeKeyPressed);
        }

    }
}

