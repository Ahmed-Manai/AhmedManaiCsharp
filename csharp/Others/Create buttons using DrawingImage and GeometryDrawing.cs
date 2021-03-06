Create buttons using DrawingImage and GeometryDrawing

<Window x:Class="Chapter05.DrawingImageExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="DrawingImage Example" Height="120" Width="360">
    <Button Name="DrawRectangle" Grid.Column="1"
      ToolTip="Draw Rectangle" Margin="4">
      <Image Width="90" Height="90">
        <Image.Source>
          <DrawingImage>
            <DrawingImage.Drawing>
              <GeometryDrawing Brush="LightGray">
                <GeometryDrawing.Geometry>
                  <RectangleGeometry Rect="0,16,80,60" />
                </GeometryDrawing.Geometry>
                <GeometryDrawing.Pen>
                  <Pen Brush="Blue" Thickness="3" />
                </GeometryDrawing.Pen>
              </GeometryDrawing>
            </DrawingImage.Drawing>
          </DrawingImage>
        </Image.Source>
      </Image>
    </Button>

</Window>

