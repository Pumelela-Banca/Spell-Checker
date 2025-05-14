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
using Microsoft.Win32;

namespace MenuesBuild
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected void FileExit_Click(object sender, RoutedEventArgs args)
        {
            // close window
            this.Close();
        }

        protected void ToolsSpellingHints_Click(object sender, RoutedEventArgs args)
        {
<<<<<<< HEAD
            string errorHints = string.Empty;

            SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);

            if (error != null)
            {
                foreach (string str in error.Suggestions)
                {
                    errorHints += $"{str}\n";
                }
                lblSpellingHints.Content = errorHints;
                expanderSpelling.IsExpanded = true;
            }
        }
        protected void MouseEnterExitArea(object sender, RoutedEventArgs args)
        {
            statBarText.Text = "Exit the Application";
        }
        protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs args)
        {
            statBarText.Text = "Show Spelling Suggestion";
        }
        protected void MouseLeaveArea(object sender, RoutedEventArgs args)
        {
            statBarText.Text = "Ready";
=======
        }
        protected void MouseEnterExitArea(object sender, RoutedEventArgs args)
        {
        }
        protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs args)
        {
        }
        protected void MouseLeaveArea(object sender, RoutedEventArgs args)
        {
>>>>>>> b01f0316c06628f10a0dd0e7049e531ee489d8c5
        }
    }
}