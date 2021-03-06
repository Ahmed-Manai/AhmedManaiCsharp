Slider Attributes

<Window x:Class="ControlDemos.Label"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ControlDemos" Height="360" Width="450">
    <Grid>
      <Slider Name="sl1" Minimum="0" Maximum="100" Value="50" IsSnapToTickEnabled="True" 
      TickPlacement="BottomRight" TickFrequency="5" IsSelectionRangeEnabled="True" 
      SelectionStart="70" SelectionEnd="100" ValueChanged="sl1_ValueChanged"/>
  </Grid>
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
using System.Windows.Input;
namespace ControlDemos
{

    public partial class Label : Window
    {

        public Label()
        {
            InitializeComponent();
        }
        private void sl1_ValueChanged(object sender, EventArgs e)
        {
            if (sl1.Value < sl1.SelectionStart)
                sl1.Value = sl1.SelectionStart;

            if (sl1.Value > sl1.SelectionEnd)
                sl1.Value = sl1.SelectionEnd;
        }

    }
}

