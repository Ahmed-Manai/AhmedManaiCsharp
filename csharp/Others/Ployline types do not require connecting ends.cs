Ployline types do not require connecting ends

<Window x:Class="WpfApplication1.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WpfApplication1" Height="360" Width="550" WindowStartupLocation="CenterScreen">
    <StackPanel>
    <Polyline Stroke ="Aqua" StrokeThickness ="20" StrokeLineJoin ="Round" 
                 Points ="8,8   36,36  8,88   280,50"/>
    </StackPanel>
</Window>

