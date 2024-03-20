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
    /// Interaction logic for PopUpName.xaml
    /// </summary>
    public partial class PopUpName : Window
    {
        public string PU_name = "";
        public PopUpName()
        {
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) 
            {
                Leaderboards lb = new Leaderboards();
                PU_name = UserInput.Text;
                lb.Show();
            }
        }
    }
}
