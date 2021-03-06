Duplicate VisualBrush

<Window x:Class="Chapter05.VisualBrushExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="VisualBrush Example" Height="250" Width="400">
    <StackPanel Margin="4" Grid.Column="0">
      <TextBlock Text="Original button:" Margin="5" />
      <Button Name="Select" ToolTip="Select" Margin="4" Width="25" Height="25">
        <Image Width="25" Height="25">
          <Image.Source>
            <DrawingImage>
              <DrawingImage.Drawing>
                <GeometryDrawing Brush="LightGray">
                  <GeometryDrawing.Geometry>
                    <PathGeometry
                      Figures="M250,75 L 50,10 75,75 60,75 20,100 40,100,40,75Z">
                      <PathGeometry.Transform>
                        RotateTransform
                        CenterX="50"
                        CenterY="50"
                        Angle="45"/>
                      </PathGeometry.Transform>
                    </PathGeometry>
                  </GeometryDrawing.Geometry>
                  <GeometryDrawing.Pen>
                    <Pen Brush="Gray" Thickness="3" />
                  </GeometryDrawing.Pen>
                </GeometryDrawing>
              </DrawingImage.Drawing>
            </DrawingImage>
          </Image.Source>
        </Image>
      </Button>


      <TextBlock Text="Copied button:" Margin="5" />
      <Button Height="50" Width="50">
        <Button.Background>
          <VisualBrush Visual="{Binding ElementName=Select}" />
        </Button.Background>
      </Button>
    </StackPanel>

</Window>

