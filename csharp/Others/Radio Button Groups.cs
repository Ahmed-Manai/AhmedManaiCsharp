Radio Button Groups

<Window x:Class="ClassicControls.RadioButtonGroups"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="RadioButtonGroups" Height="360" Width="450">
    <StackPanel>
      <GroupBox Margin="7">
        <StackPanel>
          <RadioButton>Group 1</RadioButton>
          <RadioButton>Group 1</RadioButton>
          <RadioButton>Group 1</RadioButton>
          <RadioButton Margin="0,10,0,0" GroupName="Group2">Group 2</RadioButton>
        </StackPanel>
      </GroupBox>
      <GroupBox Margin="7">
        <StackPanel>
          <RadioButton>Group 3</RadioButton>
          <RadioButton>Group 3</RadioButton>
          <RadioButton>Group 3</RadioButton>
          <RadioButton Margin="0,10,0,0" GroupName="Group2">Group 2</RadioButton>
        </StackPanel>
      </GroupBox>
    </StackPanel>
</Window>

