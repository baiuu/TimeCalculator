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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimeCalculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int seed;
        string relut;
        private void Timetoms(string hh, string mm, string ss, string ms)
        {
            seed = ((Convert.ToInt32(hh)*60+ Convert.ToInt32(mm))*60+ Convert.ToInt32(ss))*1000+ Convert.ToInt32(ms);
        }
        private void Timedecode(int end)
        {
            double MS = end / 1000;
            double mx = Math.Floor(MS) ;
            double ms = end - mx * 1000;
            double SS = mx / 60;
            double sx = Math.Floor(SS);
            double ss = mx - sx * 60;
            double MM = sx / 60;
            double hh = Math.Floor(MM);
            double mm = sx - hh * 60;
            relut = Convert.ToString(hh) + ":" + Convert.ToString(mm).PadLeft(2,'0') + ":" + Convert.ToString(ss).PadLeft(2, '0') + "." + Convert.ToString(ms).PadRight(3,'0');
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (HH1.Text == "")
                HH1.Text = "0";
            if (MM1.Text == "")
                MM1.Text = "0";
            if (SS1.Text == "")
                SS1.Text = "0";
            if (MS1.Text == "")
                MS1.Text = "0";
            Timetoms(HH1.Text, MM1.Text, SS1.Text, MS1.Text.PadRight(3,'0'));
            int deta1 = seed;
            if (HH2.Text == "")
                HH2.Text = "0";
            if (MM2.Text == "")
                MM2.Text = "0";
            if (SS2.Text == "")
                SS2.Text = "0";
            if (MS2.Text == "")
                MS2.Text = "0";
            Timetoms(HH2.Text, MM2.Text, SS2.Text, MS2.Text.PadRight(3, '0'));
            int deta2 = seed;
            int end = deta1 - deta2;
            Timedecode(end);
            output.Text = relut;
        }
    }
}
