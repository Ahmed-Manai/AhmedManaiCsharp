Use Frame to Load another Xaml file

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="#F400F8">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="Frame">
        <StackPanel>
          <Frame Source="page1.xaml" Width="300" Height="240"/>
        </StackPanel>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

