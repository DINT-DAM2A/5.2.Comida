using System.Windows;

namespace Comida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.LimpiarSeleccion();
        }
    }
}
