Vertical/Horizontal Slider

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="#F4F4F4">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="Slider">
        <StackPanel>
          <Slider Margin="9" Orientation="Horizontal" />
          <Slider Margin="9" Orientation="Horizontal" TickPlacement="TopLeft" />
          <Slider Margin="9" Orientation="Horizontal" TickPlacement="BottomRight" />
          <Slider Margin="9" Orientation="Horizontal" TickPlacement="Both" TickFrequency="2" />
        </StackPanel>
        <StackPanel Orientation="Horizontal" VerticalAlignment="Top">
          <Slider Margin="9" Orientation="Vertical" />
          <Slider Margin="9" Orientation="Vertical" TickPlacement="TopLeft" />
          <Slider Margin="9" Orientation="Vertical" TickPlacement="BottomRight" />
          <Slider Margin="9" Orientation="Vertical" TickPlacement="Both" TickFrequency="2" />
        </StackPanel>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

