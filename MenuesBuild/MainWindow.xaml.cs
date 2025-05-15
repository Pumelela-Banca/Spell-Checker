using System.IO;
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
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var openDlg = new OpenFileDialog { Filter = "Text Files |*.txt" };
            if (true == openDlg.ShowDialog())
            {
                string dataFromFile = File.ReadAllText(openDlg.FileName);
                txtData.Text = dataFromFile;
            }
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            var saveDlg = new SaveFileDialog { Filter = "Text Files | *.txt" };

            if (true == saveDlg.ShowDialog())
            {
                File.WriteAllText(saveDlg.FileName, txtData.Text);
            }
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}