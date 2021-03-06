Style With MultiTrigger

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Window.Resources>
      <Style x:Key ="TextBoxStyle" TargetType = "{x:Type TextBox}">
        <Setter Property = "Foreground" Value = "Blue"/>
        <Setter Property = "Background" Value = "Cyan"/>
        <Setter Property = "Height" Value = "36"/>
        <Setter Property = "Width" Value = "120"/>
          <Style.Triggers>
            <MultiTrigger>  
            <MultiTrigger.Conditions>
              <Condition Property = "IsFocused" Value = "True"/>
              <Condition Property = "IsMouseOver" Value = "True"/>
            </MultiTrigger.Conditions>
            <Setter Property = "Background" Value = "Yellow"/>                   
          </MultiTrigger>
        </Style.Triggers>
      </Style>
    </Window.Resources>


  <StackPanel >
    <TextBox Name = "txtOne" Style = "{StaticResource TextBoxStyle}" />    
    <TextBox Name = "txtTwo" Style = "{StaticResource TextBoxStyle}" />
    <TextBox Name = "txtThree" Style = "{StaticResource TextBoxStyle}" />
   </StackPanel>
</Window>

