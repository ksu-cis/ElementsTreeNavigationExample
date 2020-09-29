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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElementsTreeNavigationExample
{
    /// <summary>
    /// Interaction logic for OtherDescendantControl.xaml
    /// </summary>
    public partial class OtherDescendantControl : UserControl
    {
        AncestorControl ancestor;

        public OtherDescendantControl(AncestorControl ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        void OnSwitchScreen(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.Descendant);
        }
    }
}
