OpacityMask, LinearGradientBrush, RenderTransform

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="Microsoft.Samples.Graphics.RectangleExample"
    WindowTitle="Sample">
  <Canvas>
    <Rectangle Grid.Row="1" RenderTransformOrigin="1,0.5">
      <Rectangle.Fill>
        <VisualBrush Visual="{Binding ElementName=txt}"></VisualBrush>
      </Rectangle.Fill>
      <Rectangle.OpacityMask>
        <LinearGradientBrush StartPoint="0,0" EndPoint="0,1">
          <GradientStop Offset="0.3" Color="Transparent"></GradientStop>
          <GradientStop Offset="1" Color="#CCFF00"></GradientStop>
        </LinearGradientBrush>
      </Rectangle.OpacityMask>
      <Rectangle.RenderTransform>
        <ScaleTransform ScaleY="-1"></ScaleTransform>
      </Rectangle.RenderTransform>
    </Rectangle>

  </Canvas>
</Page>

