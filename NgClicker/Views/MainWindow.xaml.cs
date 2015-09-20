namespace NgClicker
{
    using System.Windows;
    using NgClicker.Models;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Model = new MainModel();
            this.DataContext = this.Model;
            this.InitializeComponent();
        }

        public MainModel Model { get; private set; }
    }
}
