Dock StatusBar

<Window x:Class="SimpleStyles.TestWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Test Window" Height="250" Width="360"
    Style="{StaticResource {x:Type Window}}"
    ResizeMode="CanResizeWithGrip">
  <DockPanel LastChildFill="False">
    <StatusBar DockPanel.Dock="Bottom">
      <StatusBarItem>
        Ready
      </StatusBarItem>
    </StatusBar>

  </DockPanel>
</Window>

