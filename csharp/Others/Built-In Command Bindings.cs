Built-In Command Bindings

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                Orientation="Horizontal" Height="30">
      <Button Command="Cut" CommandTarget="{Binding ElementName=textBox}"
        Content="{Binding RelativeSource={RelativeSource Self}, Path=Command.Text}"/>
      <Button Command="Copy" CommandTarget="{Binding ElementName=textBox}"
        Content="{Binding RelativeSource={RelativeSource Self}, Path=Command.Text}"/>
      <Button Command="Paste" CommandTarget="{Binding ElementName=textBox}"
        Content="{Binding RelativeSource={RelativeSource Self}, Path=Command.Text}"/>
      <Button Command="Undo" CommandTarget="{Binding ElementName=textBox}"
        Content="{Binding RelativeSource={RelativeSource Self}, Path=Command.Text}"/>
      <Button Command="Redo" CommandTarget="{Binding ElementName=textBox}"
        Content="{Binding RelativeSource={RelativeSource Self}, Path=Command.Text}"/>
      <TextBox x:Name="textBox" Width="360"/>
    </StackPanel>
    

</Page>

