Password for PasswordBox

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="#F1F1F1">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="TextBox">
        <StackPanel>
          <TextBox HorizontalAlignment="Center" Margin="9" Text="Edit Me" />
          <PasswordBox HorizontalAlignment="Center" Margin="9" Password="Password" />
        </StackPanel>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

