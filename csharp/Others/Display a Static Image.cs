Display a Static Image

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="400" Width="500">
    <StackPanel Orientation="Horizontal">
        <Image Margin="8" ToolTip="Bottom Image" Width="120" Source="c:\image.gif" />
    </StackPanel>
</Window>

