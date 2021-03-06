Rotate then Translate

<Window x:Class="Workspace.DockExample"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Workspace" Width="700" Height="500">

        <Canvas Height="240" Width="240">
          <Polyline
            Points="24,24 0,50 24,80 50,50 24,24 24,0" Stroke="Aqua" StrokeThickness="10"
            Canvas.Left="80" Canvas.Top="60">
            <Polyline.RenderTransform>
                <TransformGroup>
                    <TransformGroup.Children>
                        <TransformCollection>
                            <RotateTransform CenterX="30" CenterY="60" Angle="45" />
                            <TranslateTransform X="50" Y="0" />
                        </TransformCollection>
                    </TransformGroup.Children>
               </TransformGroup>
            </Polyline.RenderTransform>
          </Polyline>
          <Polyline Points="24,24 0,80 25,75 50,50 24,24 25,0" Stroke="Aqua" StrokeThickness="10"
            Opacity="0.25" Canvas.Left="75" Canvas.Top="50" /> 
        </Canvas>

</Window>

