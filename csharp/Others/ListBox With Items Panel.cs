ListBox With Items Panel

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <ListBox HorizontalAlignment="Center" VerticalAlignment="Center">

        <ListBox.ItemsPanel>
            <ItemsPanelTemplate>
                <UniformGrid />
            </ItemsPanelTemplate>
        </ListBox.ItemsPanel>

        <ListBoxItem>Item 1</ListBoxItem>
        <ListBoxItem>Item 2</ListBoxItem>
        <ListBoxItem>Item 3</ListBoxItem>
        <ListBoxItem>Item 4</ListBoxItem>
        <ListBoxItem>Item 5</ListBoxItem>
        <ListBoxItem>Item 6</ListBoxItem>
        <ListBoxItem>Item 7</ListBoxItem>
        <ListBoxItem>Item 8</ListBoxItem>
        <ListBoxItem>Item 9</ListBoxItem>
        <ListBoxItem>Item 10</ListBoxItem>


    </ListBox>
</Page>

