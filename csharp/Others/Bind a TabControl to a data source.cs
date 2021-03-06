Bind a TabControl to a data source

<Window x:Class="TabControlUsingItemTemplate.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:src="clr-namespace:TabControlUsingItemTemplate"
    Title="TabControlUsingItemTemplate" Height="250" Width="250">
  <Window.Resources>
    <ObjectDataProvider x:Key="TabListResource" ObjectType="{x:Type src:TabList}" />
    <DataTemplate x:Key="HeaderTemplate">
      <TextBlock Text="{Binding Path=Header}" />
    </DataTemplate>
    <DataTemplate x:Key="ContentTemplate">
      <TextBlock Text="{Binding Path=Content}" />
    </DataTemplate>
  </Window.Resources>

  <DockPanel>
    <TabControl ItemsSource="{Binding Source={StaticResource TabListResource}}"
                  ItemTemplate="{StaticResource HeaderTemplate}"
                  ContentTemplate="{StaticResource ContentTemplate}"/>

  </DockPanel>

</Window>
//File:Window.xaml.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
namespace TabControlUsingItemTemplate
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();
        }
    }
    public class TabItemData
    {
        private string _header;
        private string _content;

        public TabItemData(string header, string content)
        {
            _header = header;
            _content = content;
        }
        public string Header
        {
            get { return _header; }
        }
        public string Content
        {
            get { return _content; }
        }
    }
    public class TabList : ObservableCollection<TabItemData>
    {
        public TabList(): base()
        {

            Add(new TabItemData("Header 1", "Content 1"));
            Add(new TabItemData("Header 2", "Content 2"));
            Add(new TabItemData("Header 3", "Content 3"));

        }
    }
}

