GroupBox Header with mixed content

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Center" VerticalAlignment="Center">
<GroupBox>
  <GroupBox.Header>
    <StackPanel Orientation="Horizontal">
      <TextBlock Text="A" FontStyle="Italic" VerticalAlignment="Center" />
      <TextBlock Text="B" VerticalAlignment="Center" />
      <Ellipse Fill="Red" Width="25" Height="80" />
      <TextBlock Text="C" VerticalAlignment="Center" FontWeight="Bold" />
      <Button Content="_header" VerticalAlignment="Center" />
    </StackPanel>
  </GroupBox.Header>
  <TextBlock Text="Boring content" />
</GroupBox>
</Page>

