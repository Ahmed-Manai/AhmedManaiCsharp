VisualBrush and DrawingBrush

<Window x:Class="WPFBrushes.VisualBrushInXAML"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="VisualBrush" Height="600" Width="400">

  <Window.Resources>
    <DrawingBrush x:Key="MyCustomDrawing">
      <DrawingBrush.Drawing>
        <GeometryDrawing Brush="Red">
          <GeometryDrawing.Geometry>
            <GeometryGroup>
              <EllipseGeometry RadiusX="22" RadiusY="25" Center="30,50" />
              <EllipseGeometry RadiusX="22" RadiusY="55" Center="60,50" />
            </GeometryGroup>
          </GeometryDrawing.Geometry>
          <GeometryDrawing.Pen>
            <Pen Thickness="1.5" Brush="LightBlue" />
          </GeometryDrawing.Pen>
        </GeometryDrawing>
      </DrawingBrush.Drawing>
    </DrawingBrush>
  </Window.Resources>

  <Grid>
    <StackPanel Margin="5,5,5,5">

      <TextBlock Margin="5,5,5,5">Source Visual:</TextBlock>
      <Button Content="DrawingBrush" Height="125" Width="275" Name="MyVisual" 
        Background="{StaticResource MyCustomDrawing}"/>

      <TextBlock Margin="5,5,5,5">VisualBrush:</TextBlock>
      <Button Foreground="Black" Height="120" Width="250">
        <Button.Background>
          <VisualBrush Visual="{Binding ElementName=MyVisual}"/>
        </Button.Background>
      </Button>
    </StackPanel>
  </Grid>
</Window>

