SolidColorBrush described using 8-digit hexadecimal notation

<!--
The first two digits describe the opacity of the color. 
The remaining digits specify the amount of red, green, and blue in the color.
-->
            
<Window x:Class="WpfApplication1.ShapesWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ShapesWindow" Height="180" Width="500">
      <Window.Resources>
        <Style TargetType="{x:Type Rectangle}">
          
          <Setter Property="Stroke" Value="White"/>
          <Setter Property="StrokeThickness" Value="1"/>
        </Style>
      </Window.Resources>
    <Canvas>

      <Rectangle Width="45" Height="45" Fill="#0000FF" />

    </Canvas>
</Window>

