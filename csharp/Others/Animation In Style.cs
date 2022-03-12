Animation In Style

<Window x:Class="Animation.AnimationInStyle"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"    
    Title="AnimationInStyle" Height="250" Width="250">
  <Window.Resources>
    
    <Style x:Key="GrowButtonStyle">
      <Style.Triggers>
        <Trigger Property="Button.IsPressed" Value="True">
          <Trigger.EnterActions>
            <BeginStoryboard>
              <Storyboard>
                <DoubleAnimation Storyboard.TargetProperty="Width"
                  To="250" Duration="0:0:5"></DoubleAnimation>
              </Storyboard>
            </BeginStoryboard>
          </Trigger.EnterActions>
        </Trigger>
      </Style.Triggers>      
    </Style>
    
  </Window.Resources>
  <Button Padding="10" Name="cmdGrow" Height="50" Width="180" Style="{StaticResource GrowButtonStyle}"
          HorizontalAlignment="Center" VerticalAlignment="Center">
      Click and Make Me Grow    
  </Button>
</Window>
