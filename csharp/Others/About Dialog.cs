About Dialog

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  Title="About WPF" SizeToContent="WidthAndHeight"
  Background="Red">
  <StackPanel>
  <Label FontWeight="Bold" FontSize="20" Foreground="blue">
    WPF Version 
  </Label>
  <Label>2012</Label>
  <Label>Installed DLL:</Label>
  <ListBox>
    <ListBoxItem>1</ListBoxItem>
    <ListBoxItem>2</ListBoxItem>
  </ListBox>
  <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
    <Button MinWidth="40" Margin="8">Help</Button>
    <Button MinWidth="40" Margin="8">OK</Button>
  </StackPanel>
  <StatusBar>You have successfully registered this product.</StatusBar>
  </StackPanel>
</Window>
