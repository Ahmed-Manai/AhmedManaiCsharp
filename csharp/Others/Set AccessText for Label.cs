Set AccessText for Label

<StackPanel
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" x:Class="LabelSimple.Pane1">

    <DockPanel Margin="25,10,4,4" Grid.Column="0" Grid.Row="4">
        <TextBox Name="textBox1" Width="60" Height="24"/>
        <Label Width="300" HorizontalAlignment="Left"
             Target="{Binding ElementName=textBox1}">
            <AccessText TextWrapping="WrapWithOverflow">
                _Another long piece of text that requires text wrapping
          goes here.
            </AccessText>
        </Label>
    </DockPanel>


</StackPanel>

