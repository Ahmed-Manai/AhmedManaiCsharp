MenuItems with Commands

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Top">
    <Menu>
        <MenuItem Header="_Edit">
            <MenuItem Header="_Undo" Command="Undo" />
            <MenuItem Header="_Redo" Command="Redo"/>
            <Separator />
            <MenuItem Header="Cu_t" Command="Cut" />
            <MenuItem Header="_Copy" Command="Copy" />
            <MenuItem Header="_Paste" Command="Paste" />
            <MenuItem Header="_Delete" Command="Delete" />
            <Separator />
            <MenuItem Header="Select _All" Command="SelectAll" />
        </MenuItem>
    </Menu>
</Page>

