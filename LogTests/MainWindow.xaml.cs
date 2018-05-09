using Anotar.NLog;
using System.Windows;

namespace LogTests
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LogTo.Error("Test");
        }
    }
}
