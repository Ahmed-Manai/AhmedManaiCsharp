Opacity Mask from Drawing

<Window x:Class="Workspace.DockExample"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Workspace" Width="600" Height="880">

    <Image Height="120" Width="240" Source="c:\image.jpg">
      <Image.OpacityMask>
        <DrawingBrush>
          <DrawingBrush.Drawing>
            <GeometryDrawing>
              <GeometryDrawing.Brush>
                <RadialGradientBrush>
                  <RadialGradientBrush.GradientStops>
                    <GradientStop Offset="0" Color="Aqua" />
                    <GradientStop Offset="1" Color="Transparent" />
                  </RadialGradientBrush.GradientStops>
                </RadialGradientBrush>
              </GeometryDrawing.Brush>
              <GeometryDrawing.Geometry>
                <RectangleGeometry Rect="0.05,0.05 0.9,0.9" />
              </GeometryDrawing.Geometry>
              <GeometryDrawing.Pen>
                <Pen Thickness="0.1" Brush="Aqua" />
              </GeometryDrawing.Pen>
            </GeometryDrawing>
          </DrawingBrush.Drawing>
        </DrawingBrush>
      </Image.OpacityMask>
    </Image>

</Window>

