using System.Windows;

namespace CashRegister.UICore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel ViewModel;

        public MainWindow()
        {
            InitializeComponent();

            // Set the data context for data binding
            DataContext = ViewModel = new MainWindowViewModel();

            // When the view has been loaded, give the view model
            // a chance to initialize.
            Loaded += async (_, __) => await ViewModel.InitAsync();
        }
    }
}
