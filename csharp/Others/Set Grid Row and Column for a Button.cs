Set Grid Row and Column for a Button

<Window x:Class="VeryBasicXAMLFile.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="VeryBasicXAMLFile" Height="320" Width="440"
    >
    <Grid>
      <Button 
        Width="136" 
        Height="30" 
        Name="button1"
        Margin="75,55,0,0" 
        Grid.RowSpan="1" 
        Grid.Row="0"
        VerticalAlignment="Top" 
        HorizontalAlignment="Left"
        Grid.Column="0" 
        Grid.ColumnSpan="1"
        >
        Button
        </Button>
    </Grid>
</Window>

