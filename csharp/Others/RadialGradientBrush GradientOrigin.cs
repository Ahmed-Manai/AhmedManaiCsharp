RadialGradientBrush GradientOrigin

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      WindowTitle="StackPanel vs. DockPanel">
  <Grid Width="180" Height="220">
    <Rectangle Grid.Row="1" Grid.Column="0"  Width="90" Height="90" 
      StrokeThickness="4" Margin="4">
      <Rectangle.Fill>
        <RadialGradientBrush GradientOrigin="0.5,0.5" Center="0.5,0.5" 
          RadiusX="0.5" RadiusY="0.5">
          <GradientStop Color="Cyan" Offset="0" />
          <GradientStop Color="Gray" Offset="0.45" />
          <GradientStop Color="Cyan" Offset="0.85" />
        </RadialGradientBrush>
      </Rectangle.Fill>
      <Rectangle.Stroke>
        <SolidColorBrush Color="Maroon"/>
      </Rectangle.Stroke>
    </Rectangle>
  </Grid>
</Page>

