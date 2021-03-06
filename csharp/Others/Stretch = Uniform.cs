Stretch = Uniform

<Window x:Class="Chapter9.ImageBrushExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Chapter9" Height="360" Width="500">
      <StackPanel Margin="5" Grid.Column="0" Grid.Row="1">
        <TextBlock Margin="5" Text="Stretch = Uniform" />
        <Button Width="160" Height="120">
          <Button.Background>
            <ImageBrush ImageSource="c:\image.jpg" Stretch="Uniform" />
          </Button.Background>
        </Button>
      </StackPanel>
</Window>

