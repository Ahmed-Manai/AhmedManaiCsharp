Setting AccessText properties

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="AccessTextSimple.Pane1">
  <StackPanel>
    <DockPanel Margin="36,12,4,4" Grid.Column="0" Grid.Row="5">

      <TextBox Name="textBox2" Width="60" Height="40"/>
      <Label Target="{Binding ElementName=textBox2}">
        <AccessText Background="Cyan" Foreground="Blue"    
                    FontFamily="Arial Narrow" FontSize="16" FontStyle="Italic" 
                    FontWeight="Bold">
          E_dit(Press the ALT key to see the access keys)
        </AccessText>
      </Label>
    </DockPanel>

  </StackPanel>
</StackPanel>

