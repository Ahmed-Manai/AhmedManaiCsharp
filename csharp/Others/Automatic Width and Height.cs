Automatic Width and Height

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  HorizontalAlignment="Center" VerticalAlignment="Center">
<Grid Background="Beige" ShowGridLines="True">
  <Grid.ColumnDefinitions>
    <ColumnDefinition Width="Auto" />
    <ColumnDefinition />
  </Grid.ColumnDefinitions>
  <Grid.RowDefinitions>
    <RowDefinition Height="Auto" />
    <RowDefinition Height="Auto" />
    <RowDefinition Height="Auto" />
  </Grid.RowDefinitions>
  <TextBlock Grid.Column="0" Grid.Row="0">This is a test.:</TextBlock>
  <TextBlock Grid.Column="1" Grid.Row="0">This is a test</TextBlock>
  <TextBlock Grid.Column="0" Grid.Row="1">This is a test:</TextBlock>
  <TextBlock Grid.Column="1" Grid.Row="1">This is a test</TextBlock>
  <TextBlock Grid.Column="0" Grid.Row="2">This is a test:</TextBlock>
  <TextBlock Grid.Column="1" Grid.Row="2">This is a test</TextBlock>
</Grid>
</Page>

