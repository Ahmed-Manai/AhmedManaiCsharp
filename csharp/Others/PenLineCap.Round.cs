PenLineCap.Round

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            Orientation="Horizontal">
    <StackPanel.Resources>
        <Style TargetType="{x:Type Canvas}">
            <Setter Property="Width" Value="180" />
            <Setter Property="Margin" Value="23" />
        </Style> 

        <Style x:Key="thin">
            <Setter Property="Line.X1" Value="00" />
            <Setter Property="Line.Y1" Value="66" />
            <Setter Property="Line.X2" Value="90" />
            <Setter Property="Line.Y2" Value="40" />
            <Setter Property="Line.Stroke" Value="Black" />
        </Style>

        <Style x:Key="thick"
               BasedOn="{StaticResource thin}">
            <Setter Property="Line.Stroke" Value="Maroon" />
            <Setter Property="Line.StrokeThickness" Value="25" />
        </Style>
    </StackPanel.Resources>

    <Canvas>
        <TextBlock Text="PenLineCap.Round" />
        <Line Style="{StaticResource thick}"
              StrokeStartLineCap="Round"
              StrokeEndLineCap="Round" />
        <Line Style="{StaticResource thin}" />
    </Canvas>
                
</StackPanel>

