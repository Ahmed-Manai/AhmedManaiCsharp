Using XmlDataProvider

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Center" VerticalAlignment="Center">
    <Grid HorizontalAlignment="Center" VerticalAlignment="Center">
      <Grid.Resources>
        <XmlDataProvider x:Key="myXml" XPath="/Root">
          <x:XData>
            <Root xmlns="">
              <Item id="X" flag="True" value="X" />
              <Item id="Y" flag="True" value="Y" />
              <Item id="J" flag="False" value="J" />
              <Item id="K" flag="True" value="K" />
            </Root>
          </x:XData>
        </XmlDataProvider>
      </Grid.Resources>
      <ListView DataContext="{StaticResource myXml}" ItemsSource="{Binding XPath=Item}">
        <ListView.View>
          <GridView>
            <GridViewColumn Header="ID" DisplayMemberBinding="{Binding XPath=@id}" />
            <GridViewColumn Header="Enabled">
              <GridViewColumn.CellTemplate>
                <DataTemplate>
                  <CheckBox IsChecked="{Binding XPath=@flag}" />
                </DataTemplate>
              </GridViewColumn.CellTemplate>
            </GridViewColumn>
            <GridViewColumn Header="Value">
              <GridViewColumn.CellTemplate>
                <DataTemplate>
                  <TextBox Text="{Binding XPath=@value}" Width="70" />
                </DataTemplate>
              </GridViewColumn.CellTemplate>
            </GridViewColumn>
          </GridView>
        </ListView.View>
      </ListView>
    </Grid>
</Page>

