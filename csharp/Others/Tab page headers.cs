Tab page headers

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Center" VerticalAlignment="Center">
<TabControl>
  <TabItem Header="_Button">
    <Button>Click!</Button>
  </TabItem>
  <TabItem>
    <TabItem.Header>
      <TextBlock FontSize="20">
        <AccessText>_Text</AccessText>
      </TextBlock>
    </TabItem.Header>
    <TextBlock>I Love Clementine</TextBlock>
  </TabItem>
  <TabItem>
    <TabItem.Header>
      <Ellipse Fill="Cyan" Width="40" Height="25" />
    </TabItem.Header>
    <StackPanel Orientation="Horizontal">
      <TextBlock>Ellipse:</TextBlock>
      <Ellipse Fill="Cyan" Width="120" />
    </StackPanel>
  </TabItem>
</TabControl>
</Page>

