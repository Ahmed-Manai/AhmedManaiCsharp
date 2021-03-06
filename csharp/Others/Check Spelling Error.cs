Check Spelling Error

<Window x:Class="WpfApplication1.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WpfApplication1" Height="240" Width="300" WindowStartupLocation="CenterScreen">
  <StackPanel>
    <TextBox  SpellCheck.IsEnabled ="True" AcceptsReturn ="True"
      Name ="txtData"  FontSize ="16"
      BorderBrush ="Blue" Height ="90">
    </TextBox>
    <Button Name ="btnOK" Content ="Get Selections" Width = "90" Click ="btnOK_Click"/>
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


namespace WpfApplication1
{

  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    protected void btnOK_Click(object sender, RoutedEventArgs args)
    {
   
        string spellingHints = string.Empty;
        SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);
        if (error != null)
        {
          foreach (string s in error.Suggestions)
          {
            spellingHints += string.Format("{0}\n", s);

          }
          MessageBox.Show(spellingHints, "Try these instead");
        }

    }

  }
}

