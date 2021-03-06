Use outter resource or inner resource

<Window x:Class="Resources.TwoResources"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Resources" Height="360" Width="500">

  <Window.Resources>
    <ImageBrush x:Key="TileBrush" TileMode="Tile"
                ViewportUnits="Absolute" Viewport="0 0 32 32"
                ImageSource="c:\image.jpg" Opacity="0.3"></ImageBrush>
  </Window.Resources>
  <StackPanel Margin="5">
    
    <Button Background="{StaticResource TileBrush}" Padding="5"
            FontWeight="Bold" FontSize="16" Margin="5"
              >A Tiled Button</Button>

    <Button Padding="4" Margin="4" FontWeight="Bold" FontSize="16">
      <Button.Resources>
        <ImageBrush x:Key="TileBrush" TileMode="Tile"
                    ViewportUnits="Absolute" Viewport="0 0 10 10"
                    ImageSource="c\image.jpg" Opacity="0.3"></ImageBrush>
      </Button.Resources>
      <Button.Background><StaticResource ResourceKey="TileBrush" /></Button.Background>
      <Button.Content>Another Tiled Button</Button.Content>
    </Button>

  </StackPanel>

</Window>

