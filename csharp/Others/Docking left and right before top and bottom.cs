Docking left and right before top and bottom

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      Title="Simple DockPanel"
      Width="360" Height="200">
<DockPanel>
  <Button DockPanel.Dock="Left">Left</Button>
  <Button DockPanel.Dock="Right">Right</Button>
  <Button DockPanel.Dock="Top">Top</Button>
  <Button DockPanel.Dock="Bottom">Bottom</Button>
  <Button>Fill</Button>
</DockPanel>
</Window>

