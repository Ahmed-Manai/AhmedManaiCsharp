Stretched GridSplitter

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">

        <Grid Height="120" Width="450">
          <Grid.ColumnDefinitions>
            <ColumnDefinition Width="1*" />
            <ColumnDefinition Width="6" />
            <ColumnDefinition Width="2*" />
          </Grid.ColumnDefinitions>
        
          <Ellipse Grid.Column="0" Fill="Cyan" />
          <GridSplitter Grid.Column="1" HorizontalAlignment="Stretch" />
          <Ellipse Grid.Column="2" Fill="Blue" />
        </Grid>
</Page>

