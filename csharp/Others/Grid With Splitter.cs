Grid With Splitter

<Window
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="FunWithPanels" Height="240" Width="600">
  <Grid Background ="Blue">

    <Grid.ColumnDefinitions>
      <ColumnDefinition Width ="Auto"/>
      <ColumnDefinition/>
    </Grid.ColumnDefinitions>
    
    <Label Name="lblLeft" Background ="GreenYellow" Grid.Column="0" Content ="Left!"/>
    <GridSplitter Grid.Column ="0" Width ="8"/>
    <Label Name="lblRight" Grid.Column ="1" Content ="Right!"/>
  </Grid>
</Window>

