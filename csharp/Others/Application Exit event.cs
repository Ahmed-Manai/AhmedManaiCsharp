Application Exit event

<Application x:Class="SimpleXamlApp.MyApp"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    StartupUri="MainWindow.xaml" Exit="AppExit"
    >
</Application>
//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleXamlApp
{
  public partial class MyApp : Application
  {
    void AppExit(object sender, ExitEventArgs e)
    {
      MessageBox.Show("App has exited");
      }
  }
}

