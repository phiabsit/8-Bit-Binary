using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
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
using System.Windows.Threading;

namespace _8_Bit_Binary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int roundnum = 1;
        public static int seconds = 30;
        bool _timerStatus = false;
        public static int varmin = 0;
        public static int varsec = 0;
        DispatcherTimer _pt = null;
        DispatcherTimer _dt = null;
        string Answer = "";
        int reduction = 0;
        private Stack<int> bits = new Stack<int>();

        public MainWindow()
        {
            InitializeComponent();
            _dt = new DispatcherTimer();
            _dt.Tick += _dt_Tick;
            _dt.Interval = new TimeSpan(0, 0, 0, 1, 0);
            reduction = (int)Math.Ceiling(seconds * 0.066);
            _pt = new DispatcherTimer();
            _pt.Tick += _pt_Tick;
            _pt.Interval = new TimeSpan(0, 0, 0, 1, 0);
            reduction = (int)Math.Ceiling(seconds * 0.066);
            _pt.Start();
        }

        private void _pt_Tick(object sender, EventArgs e)
        {
            varsec++;
            if (varsec > 59)
            {
                varmin++;
                varsec = 0;
            }

            if (roundnum < -1)
            {
                _pt.Stop();
            }
        }

        private void _dt_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(lblTimerDisplay.Content.ToString());
            sec--;
            if (sec == 0)
            {
                _dt.Stop();
                MessageBox.Show("You lose");
                //Leaderboards lb = new Leaderboards();
                PopUpName PUN = new PopUpName();
                PUN.Show();
            }
            lblTimerDisplay.Content = sec.ToString();
            //_dt.Start();
        }

        private void StartBtn_click(object sender, RoutedEventArgs e)
        {
            SGame();
        }
        private void SGame()
        {

            txt128.Text = "0";
            txt64.Text = "0";
            txt32.Text = "0";
            txt16.Text = "0";
            txt8.Text = "0";
            txt4.Text = "0";
            txt2.Text = "0";
            txt1.Text = "0";
            //if (seconds != 10)
            //    seconds -= 4;
            lblTimerDisplay.Content = seconds;
            GenerateNumber();
            //StartBtn.Visibility = Visibility.Hidden;
            ////StartBtn.Visibility = Visibility.Visible;
            _dt.Start();

        }

        public string convertBinary(int numToConvert)
        {
            string binary = "";

            while (numToConvert > 0)
            {
                binary = (numToConvert % 2) + binary;

                numToConvert /= 2;
            }

            while (binary.Length < 8) 
            {
                binary = "0" + binary;
            }

            return binary;
        }


        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            string binarystring = "";
            binarystring += txt128.Text.Trim();
            binarystring += txt64.Text.Trim();
            binarystring += txt32.Text.Trim();
            binarystring += txt16.Text.Trim();
            binarystring += txt8.Text.Trim();
            binarystring += txt4.Text.Trim();
            binarystring += txt2.Text.Trim();
            binarystring += txt1.Text.Trim();
            if (binarystring == Answer)
            {
                SGame();
                if (roundnum != 11)
                    seconds -= reduction;
                lblTimerDisplay.Content = seconds;
                roundnum++;
               
            }
            else
            {
                MessageBox.Show("wrong");
               
            }

            //if (seconds != 11)
            //    seconds -= 4;
            //lblTimerDisplay.Content = seconds;
            //SGame();

        }

        private void GenerateNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 256);
            Game(number);
            string binary = "";
            binary = convertBinary(number);
            Answer = binary;
        }

        private void Game(int number)
        {
            Given.Content = number;
        }

        private void txt128_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt64_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt32_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt16_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt8_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt128_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt128.Text == "0")
            {
                txt128.Text = "1";
            }
            else if (txt128.Text == "1")
            {
                txt128.Text = "0";
            }
        }

        private void txt64_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt64.Text == "0")
            {
                txt64.Text = "1";
            }
            else if (txt64.Text == "1")
            {
                txt64.Text = "0";
            }
        }

        private void txt32_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt32.Text == "0")
            {
                txt32.Text = "1";
            }
            else if (txt32.Text == "1")
            {
                txt32.Text = "0";
            }
        }

        private void txt16_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt16.Text == "0")
            {
                txt16.Text = "1";
            }
            else if (txt16.Text == "1")
            {
                txt16.Text = "0";
            }
        }

        private void txt8_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt8.Text == "0")
            {
                txt8.Text = "1";
            }
            else if (txt8.Text == "1")
            {
                txt8.Text = "0";
            }
        }

        private void txt4_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt4.Text == "0")
            {
                txt4.Text = "1";
            }
            else if (txt4.Text == "1")
            {
                txt4.Text = "0";
            }
        }

        private void txt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt2.Text == "0")
            {
                txt2.Text = "1";
            }
            else if (txt2.Text == "1")
            {
                txt2.Text = "0";
            }
        }

        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt1.Text == "0")
            {
                txt1.Text = "1";
            }
            else if (txt1.Text == "1")
            {
                txt1.Text = "0";
            }
        }



    }
}

