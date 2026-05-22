using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGame
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            LoadMenu();
        }
        private void LoadMenu()
        {
            string path = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "GameData.json"
            );

            var (scenes, menu) = StoryLoader.Load( path );
            txtTitle.Text = menu.Title;  

            if (!string.IsNullOrEmpty(menu.Background))
            {
                imgBackground.Source = new BitmapImage(
                    new Uri($"Assets/{menu.Background}", UriKind.Relative)
                );
            }

        }
        private void btnExit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnPlay_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow game = new MainWindow();
            game.Show();
            this.Close();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MainWindow game = new MainWindow();
            game.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
