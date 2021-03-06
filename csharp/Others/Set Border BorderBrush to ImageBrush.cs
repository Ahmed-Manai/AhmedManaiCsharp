Set Border's BorderBrush to ImageBrush

<Page  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
   xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
   x:Class="Microsoft.Samples.Graphics.UsingImageBrush.TilingExample" >

  <Grid Margin="24">
    <Border Grid.Row="6" Grid.Column="4" BorderThickness="23" Width="250"
     HorizontalAlignment="Left">
      <Border.BorderBrush>
        <ImageBrush ImageSource="c:\image.jpg" Viewport="-0.1,-0.1,1.5,1.5" />
      </Border.BorderBrush>
      <DockPanel>
        <TextBlock DockPanel.Dock="Top" TextWrapping="Wrap" Margin="10">This DockPanel has a border painted with an ImageBrush.</TextBlock>
      </DockPanel>
    </Border>

  </Grid>
</Page>

