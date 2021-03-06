PenLineJoin.Bevel

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            Orientation="Horizontal">
    <StackPanel.Resources>
        <Style TargetType="{x:Type TextBlock}">
            <Setter Property="Canvas.Left" Value="23" />
        </Style>

        <Style TargetType="{x:Type Canvas}">
            <Setter Property="Width" Value="180" />
            <Setter Property="Margin" Value="16" />
        </Style> 

        <Style TargetType="{x:Type Rectangle}">
            <Setter Property="Width" Value="120" />
            <Setter Property="Height" Value="90" />
            <Setter Property="Canvas.Top" Value="45" />
            <Setter Property="Canvas.Left" Value="25" />
            <Setter Property="Stroke" Value="Black" />
            <Setter Property="StrokeThickness" Value="25" />
        </Style>
    </StackPanel.Resources>

    <Canvas>
        <TextBlock Text="PenLineJoin.Bevel" />
        <Rectangle StrokeLineJoin="Bevel" />
    </Canvas>

</StackPanel>

