Draw second figure with "NonZero" FillRule

<Canvas xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        TextBlock.FontSize="18">
    <Canvas.Resources>
        <Style x:Key="star">
            <Setter Property="Polygon.Points"
                    Value="0 -96, 56, 78, -91 -30, 91 -30, -56 78" />
            <Setter Property="Polygon.Fill"
                    Value="Blue" />
            <Setter Property="Polygon.Stroke"
                    Value="Red" />
            <Setter Property="Polygon.StrokeThickness"
                    Value="3" />
        </Style>
    </Canvas.Resources>
    <TextBlock Canvas.Left="250" Canvas.Top="36"
               Text="FillRule = NonZero" />
 
    <Polygon Style="{StaticResource star}"
             FillRule="NonZero"
             Canvas.Left="400" Canvas.Top="180" />
</Canvas>

