using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Leaderboards.xaml
    /// </summary>
    public partial class Leaderboards : Window
    {

        public Leaderboards()
        {
            InitializeComponent();
            PopUpName popUpName = new PopUpName();
            using (StreamWriter sw = new StreamWriter("Name"))
            {
                sw.WriteLine(popUpName.PU_name);
                
            }

            //using (StreamReader reader = new StreamReader("Binary Search Numbers.csv"))
            //    if 
            //    {
            //        string line = "";
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            numbers.Add(int.Parse(line));
            //        }
            //    }
        }
    }
}
