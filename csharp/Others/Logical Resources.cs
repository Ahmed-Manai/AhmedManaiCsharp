Logical Resources

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  Title="Simple Window" Background="Cyan">
  
<Grid xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
  <Grid.Resources>
    <SolidColorBrush x:Key="backgroundBrush">Cyan</SolidColorBrush>
    <SolidColorBrush x:Key="borderBrush">Red</SolidColorBrush>
  </Grid.Resources>
  <Grid.Background>
    <StaticResource ResourceKey="backgroundBrush"/>
  </Grid.Background>
  <DockPanel>
    <StackPanel DockPanel.Dock="Bottom" Orientation="Horizontal"
      HorizontalAlignment="Center">
      <Button Background="{StaticResource backgroundBrush}"
        BorderBrush="{StaticResource borderBrush}" Margin="4">
        <Image Height="25" Source="c:\image.gif"/>
      </Button>
    </StackPanel>
    <ListBox/>
  </DockPanel>
</Grid>

</Window>

