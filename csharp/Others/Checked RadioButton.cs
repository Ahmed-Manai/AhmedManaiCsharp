Checked RadioButton

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="Blue">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="RadioButton">
        <RadioButton Margin="9">Normal</RadioButton>
        <RadioButton Margin="9" IsChecked="true">Checked</RadioButton>
        <RadioButton Margin="9">Normal</RadioButton>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

