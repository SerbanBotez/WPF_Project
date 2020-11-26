using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();

        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello");
            TestProblemsWindow testProblems = new TestProblemsWindow();
            testProblems.Show();
            this.Close();
        }
    }
}
