Paints a rectangle with a checkered pattern

<Window x:Class="Workspace.DockExample"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Workspace" Width="600" Height="800">
      <Rectangle Width="200" Height="200">
        <Rectangle.Fill>
          <DrawingBrush Viewport="0,0,0.25,0.25" TileMode="Tile">
            <DrawingBrush.Drawing>
              <DrawingGroup>
                <GeometryDrawing Brush="Aqua">
                  <GeometryDrawing.Geometry>
                    <RectangleGeometry Rect="0,0,1,1" />
                  </GeometryDrawing.Geometry>
                </GeometryDrawing>
                <GeometryDrawing Brush="Black"
                  Geometry="M 0,0 L0,0.5 0.5,0.5 0.5,1 1,1 1,0.5 0.5,0.5 0.5,0" />
              </DrawingGroup>
            </DrawingBrush.Drawing>
          </DrawingBrush>
        </Rectangle.Fill>
      </Rectangle>

</Window>

