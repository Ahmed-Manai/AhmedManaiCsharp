File menu

<Window x:Class="ControlDemos.menu"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ControlDemos" Height="400" Width="600">
    <Grid>
      <Menu Width="25" Margin="8, 8, 5, 5" HorizontalAlignment="Left" Background="Blue">
        <MenuItem Header="_File">
          <MenuItem Header="_New" IsCheckable="true"/>
          <MenuItem Header="_Open" IsCheckable="true"/>
          <MenuItem Header="_Close" IsCheckable="true"/>
          <Separator/>
          <MenuItem Header="Open Previous">
            <MenuItem Header="Word Documents" />
            <MenuItem Header="Source Code" >
              <MenuItem Header="C# Files" />
            </MenuItem>
          </MenuItem>
          <Separator/>
          <MenuItem Header="E_xit">
          </MenuItem>
        </MenuItem>
      </Menu>

  </Grid>
</Window>

