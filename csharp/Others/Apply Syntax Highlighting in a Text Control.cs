Apply Syntax Highlighting in a Text Control

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Window1" Height="500" Width="700">
  <Grid>
    <RichTextBox x:Name="rtbTextContent" TextChanged="RichTextBox_TextChanged" />
  </Grid>
</Window>
//File:Window.xaml.cs
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfApplication1
{

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        
        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextRange textRange = new TextRange(rtbTextContent.Document.ContentStart, rtbTextContent.Document.ContentEnd);
            rtbTextContent.TextChanged -= RichTextBox_TextChanged;
            textRange.ClearAllProperties();
            ApplyFormatting();
            rtbTextContent.TextChanged += RichTextBox_TextChanged;
        }

        private void ApplyFormatting()
        {
            TextPointer tp = rtbTextContent.Document.ContentStart;
            tp = FindNextString(tp);

            TextPointer textRangeEnd = tp.GetPositionAtOffset(1, LogicalDirection.Forward);

            TextRange tokenTextRange = new TextRange(tp, tp.GetPositionAtOffset(1, LogicalDirection.Forward));

            tokenTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
        }

        private TextPointer FindNextString(TextPointer tp)
        {
            char[] buffer = new char[1];
            tp.GetTextInRun(LogicalDirection.Forward, buffer, 0, 1);
            return tp;
        }
    }
}

