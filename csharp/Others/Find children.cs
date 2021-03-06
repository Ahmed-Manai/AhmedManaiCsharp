Find children

using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


public class UIHelper
{
    private static IEnumerable<T> FindChildren<T>(DependencyObject parent) where T : class
    {
        var count = VisualTreeHelper.GetChildrenCount(parent);
        if (count > 0)
        {
            for (var j = 0; j < count; j++)
            {
                var child = VisualTreeHelper.GetChild(parent, j);
                var t = child as T;
                if (t != null)
                    yield return t;

                var children = FindChildren<T>(child);
                foreach (var item in children)
                    yield return item;
            }
        }
    }

    public static void SetDataContext<T>(DependencyObject parent, T dataContext) where T : class
    {
        var textBoxes = FindChildren<TextBox>(parent);
        foreach (var item in textBoxes)
        {
            item.DataContext = dataContext;
        }
    }

}

