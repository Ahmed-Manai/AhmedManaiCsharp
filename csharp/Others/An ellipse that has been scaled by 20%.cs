An ellipse that has been scaled by 20%

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
        xmlns:sys="clr-namespace:System;assembly=mscorlib" 
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" >
  <Grid>

    <Ellipse Fill ="Red" Grid.Row="0" Grid.Column="2" Width="8" Height="8">
      <Ellipse.RenderTransform>
        <ScaleTransform ScaleX ="16" ScaleY ="16"/>
      </Ellipse.RenderTransform>
    </Ellipse>

  </Grid>

</Window>

