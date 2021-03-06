Four-quadrant Cartesian coordinate system

<Grid xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Grid.Resources>
        <Style TargetType="{x:Type Canvas}">
            <Setter Property="Width" Value="120" />
            <Setter Property="Height" Value="120" />
            <Setter Property="HorizontalAlignment" Value="Center" />
            <Setter Property="VerticalAlignment" Value="Center" />
        </Style>

        <Style TargetType="{x:Type Path}">
            <Setter Property="Fill" Value="Red" />
            <Setter Property="Data">
                <Setter.Value>
                    <EllipseGeometry Center="0 0" RadiusX="4" RadiusY="4" />
                </Setter.Value>
            </Setter>
        </Style>
    </Grid.Resources>


    <Canvas Grid.Column="3">
        <Canvas.RenderTransform>
            <TransformGroup>
                <ScaleTransform ScaleY="-1" />
                <TranslateTransform X="50" Y="50" />
            </TransformGroup>
        </Canvas.RenderTransform>

        <Line X1="0" Y1="0" X2="50" Y2="50" Stroke="Black" />
        <Polyline Points="-50 -50 50 -50 50 50 -50 50 -50 -50" Stroke="Blue" />
        <Path />
    </Canvas>

</Grid>

