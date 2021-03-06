Image tile

<Window x:Class="Chapter05.ImageBrushTile"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="ImageBrush Tiling" Height="360" Width="500">
      <StackPanel Margin="5" Grid.Column="0" Grid.Row="0">
        <TextBlock Margin="4,4,4,0" Text="TileMode = Tile" />
        <TextBlock Margin="4,0,5,5" Text="Unit: Absolute" />
        <Button Width="150" Height="120">
          <Button.Background>
            <ImageBrush ImageSource="c:\image.jpg"
              Viewport="0,0,25,25" TileMode="Tile" ViewportUnits="Absolute" />
          </Button.Background>
        </Button>
      </StackPanel>
</Window>      

