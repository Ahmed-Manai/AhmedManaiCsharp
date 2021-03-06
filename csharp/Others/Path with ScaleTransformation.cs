Path with ScaleTransformation

<Window x:Class="Animation.KeySplineAnimation"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="KeySplineAnimation" Height="280" Width="800">
    <Canvas Margin="12">

        <Path Stroke="Aqua" StrokeThickness="1" StrokeDashArray="2 1" Canvas.Top="25">
            <Path.Data>
                <PathGeometry>
                    <PathFigure>
                        <BezierSegment Point1="24,0" Point2="60,80" Point3="90,90" />
                    </PathFigure>
                </PathGeometry>
            </Path.Data>
            <Path.RenderTransform>
                <ScaleTransform ScaleX="2.5"></ScaleTransform>
            </Path.RenderTransform>
        </Path>
        <Path Stroke="Aqua" StrokeThickness="1" StrokeDashArray="2 1" Canvas.Left="280" Canvas.Top="25">
            <Path.Data>
                <PathGeometry>
                    <PathFigure>
                        <BezierSegment Point1="23,80" Point2="23,40" Point3="80,100" />
                    </PathFigure>
                </PathGeometry>
            </Path.Data>
            <Path.RenderTransform>
                <ScaleTransform ScaleX="2.5"></ScaleTransform>
            </Path.RenderTransform>
        </Path>
    </Canvas>
</Window>

