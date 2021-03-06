Bind to XML Data embed the data directly

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="300" Width="200">
    <Window.Resources>
        <XmlDataProvider x:Key="CountriesXML">
            <x:XData>
                <Countries xmlns="">
                    <Country Name="Germany" Continent="Europe" />
                    <Country Name="USA" Continent="NorthAmerica" />
                    <Country Name="Australia" Continent="Australia" />
                </Countries>
            </x:XData>
        </XmlDataProvider>
    </Window.Resources>
    <Grid>
        <ListBox
            ItemsSource="{Binding Source={StaticResource CountriesXML}, XPath=/Countries/Country/@Name}"    
        />
    </Grid>
</Window>

