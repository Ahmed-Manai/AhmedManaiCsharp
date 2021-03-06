Command Enabling

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="CommandEnabling" Height="400" Width="400"
    >
  <Grid>
    <Menu VerticalAlignment="Top">
      <MenuItem Header="_Edit">
        <MenuItem Command="Redo" />
      </MenuItem>
    </Menu>
  </Grid>
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


namespace WpfApplication1
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();

            CommandBinding redoCommandBinding = new CommandBinding(ApplicationCommands.Redo);
            redoCommandBinding.CanExecute += RedoCommandCanExecute;
            CommandBindings.Add(redoCommandBinding);
        }

        void RedoCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute =  DateTime.Now.Second % 2 > 1;
        }
    }
}

