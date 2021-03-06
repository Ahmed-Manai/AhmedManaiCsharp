Expander control

<Window x:Class="WpfApplication1.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Control Review" Height="240" Width="600" WindowStartupLocation="CenterScreen">
    <Grid>
        <Button Name="btnPurchaseOptions" Height="80" Width = "400">
            <StackPanel>
                <Label Name="lblInstructions" Foreground = "Blue" Content = "Select Your Options and Press to Commit"/>
                <StackPanel Orientation = "Horizontal">
                    <Expander Name="colorExpander" Header = "Color">
                        <Label Foreground = "Blue" Content = "AAA"/>
                    </Expander>
                    <Expander Name="MakeExpander" Header = "Make">
                        <Label Foreground = "Blue" Content = "AAA"/>
                    </Expander>
                    <Expander Name="paymentExpander" Header = "Payment Plan">
                        <Label Foreground = "Blue" Content = "AAA"/>
                    </Expander>
                </StackPanel>
            </StackPanel>
        </Button>
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


namespace WpfApplication1
{
  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();
      lblInstructions.FontSize = 16;
      btnPurchaseOptions.Click +=new RoutedEventHandler(btnPurchaseOptions_Click);
    }
    private void btnPurchaseOptions_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Button has been clicked");
    }
  } 
}

