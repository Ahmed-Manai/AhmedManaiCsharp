TranslateTransform X: 50 / Y: 0

<Window x:Class="Workspace.DockExample"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Workspace" Width="660" Height="500">
      <Canvas Width="240" Height="240">
          <Rectangle Height="60" Width="60" 
            Fill="#CCCCFF" Stroke="Cyan" StrokeThickness="2"
            Canvas.Left="120" Canvas.Top="120">
            <Rectangle.RenderTransform>
              <TranslateTransform X="50" Y="0" />
            </Rectangle.RenderTransform>
          </Rectangle>
          <Rectangle Style="{StaticResource MarkerRectangleStyle}"  />            
        </Canvas>

</Window>

