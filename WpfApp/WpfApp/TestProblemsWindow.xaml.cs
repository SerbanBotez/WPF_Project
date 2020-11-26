using System.Windows;


namespace WpfApp
{
    /// <summary>
    /// Interaction logic for TestProblemsWindow.xaml
    /// </summary>
    public partial class TestProblemsWindow : Window
    {
        public TestProblemsWindow()
        {
            InitializeComponent();
        }

        private void QuestionViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            WpfApp.ViewModel.QuestionViewModel questionViewModelObject =
               new WpfApp.ViewModel.QuestionViewModel();
            questionViewModelObject.LoadQuestions();

            QuestionViewControl.DataContext = questionViewModelObject;
        }
    }
}
