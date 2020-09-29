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
    /// Interaction logic for AncestorControl.xaml
    /// </summary>
    public partial class AncestorControl : UserControl
    {
        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

        /// <summary>
        /// Constucts a new AncestorControl
        /// </summary>
        public AncestorControl()
        {
            InitializeComponent();
            descendant.Ancestor = this;
            screens.Add(Screen.Descendant, descendant);
            screens.Add(Screen.OtherDescendant, new OtherDescendantControl(this));
        }

        /// <summary>
        /// Displays the supplied <paramref name="message"/>
        /// </summary>
        /// <param name="message">The message to print</param>
        public void SayMessage(string message)
        {
            messageTextBlock.Text = message;
        }

        /// <summary>
        /// Switches the displayed screen
        /// </summary>
        /// <param name="screen">The identity of the screen to show</param>
        public void SwitchScreen(Screen screen)
        {
            switchableContent.Child = screens[screen];
        }
    }
}
