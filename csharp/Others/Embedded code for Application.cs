Embedded code for Application

<Application x:Class="SimpleXamlApp.MyApp"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    StartupUri="MainWindow.xaml" Exit ="AppExit"
    >
  <x:Code>
    void AppExit(object sender, ExitEventArgs e)
    {
      MessageBox.Show("App has exited");
    }
  </x:Code>
</Application>

