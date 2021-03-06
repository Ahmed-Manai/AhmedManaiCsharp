Freezables and element

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">

    
    <StackPanel Orientation="Horizontal"
      xmlns:po="http://schemas.microsoft.com/winfx/2006/xaml/presentation/options"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
      mc:Ignorable="po">
      <StackPanel.Resources>
        <EllipseGeometry x:Key="pathDescription"
                         po:Freeze="True"
                         RadiusX="120" RadiusY="60" Center="120,60" />
      </StackPanel.Resources>
    
      <Path Data="{StaticResource pathDescription}" Fill="Green" />
      <Path Data="{StaticResource pathDescription}" Fill="Cyan" />
      <Path Data="{StaticResource pathDescription}" Fill="Black" />
    
    </StackPanel>


</Page>

