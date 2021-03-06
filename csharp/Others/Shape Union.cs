Shape Union

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="Microsoft.Samples.Graphics.RectangleExample"
    Title="Sample">
    <Window.Resources>
        <RectangleGeometry x:Key="rect" Rect="0 0 80 80"></RectangleGeometry>
        <EllipseGeometry x:Key="ellipse" Center="85 50" RadiusX="60" RadiusY="35"></EllipseGeometry>
    </Window.Resources>
    <Canvas>
        <Path Fill="Maroon" Stroke="Red" Margin="4">
            <Path.Data>
                <CombinedGeometry GeometryCombineMode="Union"
            CombinedGeometry.Geometry1="{StaticResource rect}"
            CombinedGeometry.Geometry2="{StaticResource ellipse}">
                </CombinedGeometry>
            </Path.Data>
        </Path>
        <TextBlock Margin="10" VerticalAlignment="Center">Union</TextBlock>

    </Canvas>
</Window>

