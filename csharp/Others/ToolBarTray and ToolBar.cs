ToolBarTray and ToolBar

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="#F400F4">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="ToolBar">
        <StackPanel>
          <ToolBarTray>
            <ToolBar Grid.Row="1">
              <Button>Button</Button>
              <CheckBox>CheckBox</CheckBox>
              <TextBox>TextBox</TextBox>
            </ToolBar>
          </ToolBarTray>
        </StackPanel>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

