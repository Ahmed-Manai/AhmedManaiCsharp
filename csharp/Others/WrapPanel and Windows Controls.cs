WrapPanel and Windows Controls

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Panel" Height="360" Width="500">
  <WrapPanel Background="Red">
    <Label Width="320" Height="36" FontSize="16">Information</Label>
    <Label>1</Label>
    <TextBox Width="240" Height="25"/>
    <Label>2</Label>
    <TextBox Name="txtColor" Width="200" Height="25"/>
    <Label>3</Label>
    <TextBox Width="200" Height="25"/>
    <Button Name="btnOK" Width="80">OK</Button>
  </WrapPanel>
</Window>

