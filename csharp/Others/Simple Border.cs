Simple Border

<Window x:Class="Content.SimpleBorder"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="SimpleBorder" Height="400" Width="400">
  <Border Margin="4" Padding="4" Background="Blue" 
          BorderBrush="SteelBlue" BorderThickness="3,5,3,5" CornerRadius="3"
          VerticalAlignment="Top">
    <StackPanel>
      <Button Margin="2">1</Button>
      <Button Margin="2">2</Button>
      <Button Margin="2">3</Button>
    </StackPanel>
  </Border>
</Window>

