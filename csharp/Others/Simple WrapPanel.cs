Simple WrapPanel

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Fun with Panels!" Height="300" Width="400">
  <WrapPanel Background="LightSteelBlue">
    <Label Name="lblInstruction" Width="360" Height="32" FontSize="16">Enter Car Information</Label>
    <Label Name="lblMake">Make</Label>
    <TextBox Name="txtMake" Width="200" Height="25"/>
    <Label Name="lblColor">Color</Label>
    <TextBox Name="txtColor" Width="200" Height="25"/>
    <Label Name="lblPetName">Pet Name</Label>
    <TextBox Name="txtPetName" Width="200" Height="25"/>
    <Button Name="btnOK" Width="80">OK</Button>
  </WrapPanel>
</Window>

