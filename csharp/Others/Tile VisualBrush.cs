Tile VisualBrush

<Page  
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
  x:Class="Microsoft.Samples.Graphics.UsingVisualBrush.PaintingWithVisuals">
    <StackPanel>
        <Rectangle Width="180" Height="160" Stroke="Red" Margin="0,0,5,0">
            <Rectangle.Fill>
                <VisualBrush Viewport="0,0,95,35" ViewportUnits="Absolute" TileMode="Tile">
                    <VisualBrush.Visual>
                        <StackPanel Background="Transparent">
                            <TextBlock FontSize="10pt" Margin="10">I Love Clementine</TextBlock>
                        </StackPanel>
                    </VisualBrush.Visual>
                </VisualBrush>
            </Rectangle.Fill>
        </Rectangle>
    </StackPanel>
</Page>

