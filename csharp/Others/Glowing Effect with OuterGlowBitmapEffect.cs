Glowing Effect with OuterGlowBitmapEffect

<Window x:Class="BitmapEffectsExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Bitmap Effects" Height="400" Width="600">
    <StackPanel Margin="4,25,4,4" Grid.Column="0" Grid.Row="1">
      <Button Content="A Growing Button" Width="200" Height="36" Margin="8">
        <Button.BitmapEffect>
          <OuterGlowBitmapEffect GlowColor="Gray"
            GlowSize="16" Noise="1" />
        </Button.BitmapEffect>
      </Button>
      <TextBlock Text="Growing" FontSize="36" FontWeight="Bold"
        Foreground="White" Margin="5">
        <TextBlock.BitmapEffect>
          <OuterGlowBitmapEffect GlowColor="Gray"
            GlowSize="10" Noise="0.5" />
        </TextBlock.BitmapEffect>
      </TextBlock>
    </StackPanel>

</Window>

