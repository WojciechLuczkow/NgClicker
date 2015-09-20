using NgClicker.Models;
using System.Windows;

namespace NgClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Model = new MainModel();
            this.DataContext = this.Model;
            InitializeComponent();
        }

        public MainModel Model { get; private set; }
    }
}
