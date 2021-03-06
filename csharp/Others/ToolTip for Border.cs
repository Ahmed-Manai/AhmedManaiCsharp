ToolTip for Border

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="#F400F4">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="ToolTip">
        <StackPanel>
          <Border Margin="8" Background="#EEE" Width="180" Height="60"  CornerRadius="2">
            <Border.ToolTip>
              I Love Clementine
            </Border.ToolTip>
            <TextBlock Foreground="#AAA" VerticalAlignment="Center" 
               HorizontalAlignment="Center">(Hover Over Me)</TextBlock>
          </Border>
        </StackPanel>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

