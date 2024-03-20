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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _8_Bit_Binary
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        //private void Exit_Click(object sender, RoutedEventArgs e)
        //{
        //    //this.Close();
        //}

        //private void About_Click(object sender, RoutedEventArgs e)
        //{
        //    AboutUs aboutUs = new AboutUs();
        //    aboutUs.Show();
        //    this.Close();
        //}

        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            //this.Close();
        }

        private void Leaderboards_Click(object sender, RoutedEventArgs e)
        {
            Leaderboards lb = new Leaderboards();
            lb.Show();
        }
    }
}
