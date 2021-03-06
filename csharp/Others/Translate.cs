Translate

<Window x:Class="Workspace.DockExample"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Workspace" Width="660" Height="500">
        <Canvas Height="240" Width="240">
          <Polyline Points="25,25 0,50 25,75 50,50 25,25 25,0" Stroke="Blue" StrokeThickness="10"
            Canvas.Left="80" Canvas.Top="50">
            <Polyline.RenderTransform>
              <TranslateTransform X="50" Y="0" />
            </Polyline.RenderTransform>
          </Polyline>
          
          <!-- Shows the original position of the polyline. -->
          <Polyline Points="25,25 0,50 25,75 50,50 25,25 25,0" Stroke="Blue" StrokeThickness="10"
            Opacity="0.25" Canvas.Left="75" Canvas.Top="50" />            
        </Canvas>

</Window>

