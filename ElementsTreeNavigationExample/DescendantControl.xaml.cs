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
    /// Interaction logic for DescendantControl.xaml
    /// </summary>
    public partial class DescendantControl : UserControl
    {
        /// <summary>
        /// The ancestor of this control
        /// </summary>
        public AncestorControl Ancestor { get; set; }

        /// <summary>
        /// Constructs a new Descendant control
        /// </summary>
        public DescendantControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Say Hello" button click
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e">The event params</param>
        void onSayHello(object sender, RoutedEventArgs e)
        {
            var ancestor = (AncestorControl)((Grid)((Border)this.Parent).Parent).Parent;
            ancestor.SayMessage("Hello there!");
        }

        /// <summary>
        /// Handles the "Say Goodbye" button click
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event params</param>
        void onSayGoodbye(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is AncestorControl || parent is null));
            if (parent is AncestorControl ancestor)
            {
                ancestor.SayMessage("Goodbye!");
            }
        }

        /// <summary>
        /// Handles the "Switch Screen" button click
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e">The event args</param>
        void onSwitchScreen(object sender, RoutedEventArgs e)
        {
            Ancestor.SayMessage("Here I am!");
            Ancestor.SwitchScreen(Screen.OtherDescendant);
        }

    }
}
