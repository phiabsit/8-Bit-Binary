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
        List<string[]> data = new List<string[]> ();

        public Leaderboards()
        {
            InitializeComponent();

            using (StreamReader reader = new StreamReader("LB_Name1.csv"))
            {
                string[] Array = new string[] { };
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Array = line.Split(',');
                    if(line != "")
                    {
                        data.Add (Array);
                    }
                    

                }

                Sort();
            }
        }

        private void Sort()
        {
            string[] Array = new string[] { };
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data.Count - 1; j++)
                {
                    if (int.Parse(data[j][1]) < int.Parse(data[j + 1][1]))
                    {
                        Array = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = Array;
                    }
                }
            }
             for (int i = 0;i < data.Count; i++)
            {
                LB.Items.Add(data[i][0]);
                Round.Items.Add(data[i][1]);
                LB_Time.Items.Add(data[i][2] + ":" + data[i][3]);
            }
        }
    }
}

