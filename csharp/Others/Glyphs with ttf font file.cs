Glyphs with ttf font file

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Glyphs and Fonts" Height="400" Width="600"
    >
  <StackPanel>
    <Glyphs FontUri="C:\Windows\Fonts\Calibri.ttf" FontRenderingEmSize="40"
        UnicodeString="Superman" Fill="Blue" OriginY="30" />
  </StackPanel>
</Window>

