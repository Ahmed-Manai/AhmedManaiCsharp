Application Startup event

<Application x:Class="Microsoft.Samples.WinFX.AlarmClock.MyApp"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Startup="AppStartup"
    >
</Application>

//File:Window.xaml.cs
using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;
using System.Windows.Media;

namespace Microsoft.Samples.WinFX.AlarmClock
{

    public partial class MyApp : Application
    {
        void AppStartup(object sender, StartupEventArgs e)
        {

        }

    }
}

