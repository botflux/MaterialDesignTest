using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialDesignTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private ICommand colorMenu = new RelayCommand<MainWindow>((window) =>
        {
            window.grid_welcome.Visibility = Visibility.Hidden;
            window.grid_changeColor.Visibility = Visibility.Visible;
        });

        public ICommand ColorMenu
        {
            get
            {
                return colorMenu;
            }
        }

        private void btn_showLeftPanel_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = this.FindResource("CloseMenu") as Storyboard; 
            sb.Begin();
        }
    }
}
