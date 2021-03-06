Load Xaml Resource

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation">

    <Button Name="MyButton" HorizontalAlignment="Center" Margin="20">Button</Button>

    <Ellipse Width="240" Height="120" Margin="20" Stroke="Red" StrokeThickness="10" />

    <ListBox Width="80" Height="80" Margin="20">
        <ListBoxItem>Sunday</ListBoxItem>
        <ListBoxItem>Monday</ListBoxItem>
        <ListBoxItem>Tuesday</ListBoxItem>
        <ListBoxItem>Wednesday</ListBoxItem>

    </ListBox>

</StackPanel>
//File:Window.xaml.cs
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace MyNameSpace.LoadXamlResource
{
    public class LoadXamlResource : Window
    {

        public LoadXamlResource()
        {
            Title = "Load Xaml Resource";

            Uri uri = new Uri("pack://application:,,,/LoadXamlResource.xml");
            Stream stream = Application.GetResourceStream(uri).Stream;
            FrameworkElement el = XamlReader.Load(stream) as FrameworkElement;
            Content = el;

            Button btn = el.FindName("MyButton") as Button;

            if (btn != null)
                btn.Click += ButtonOnClick;
        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Console.WriteLine(args.Source.ToString());
        }
    }
}

