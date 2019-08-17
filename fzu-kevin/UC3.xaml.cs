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

namespace fzu_kevin
{
    /// <summary>
    /// UC3.xaml 的交互逻辑
    /// </summary>
    public partial class UC3 : UserControl
    {
        public UC3()
        {
            InitializeComponent();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            this.h1.Clear();
            this.h2.Clear();
            this.h3.Clear();
            this.h4.Clear();
            this.h5.Clear();
            this.t1.Clear();
            this.t2.Clear();
            this.t3.Clear();
            this.t4.Clear();
            this.d.Clear();
            this.dt.Clear();
            this.Qsk.Clear();
            this.Qpk.Clear();
            this.H.Clear();
            this.pp1.Clear();
            this.pp2.Clear();
            this.ff.Clear();

        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            double qsk;
            double qpk;
            double d_h1;
            double d_h2;
            double d_h3;
            double d_h4;
            double d_h5;
            double d_t1;
            double d_t2;
            double d_t3;
            double d_t4;
            double d_d;
            double d_t;
            double h;
            double p1;
            double p2;
            double fi;


            double.TryParse(h1.Text, out d_h1);
            double.TryParse(h2.Text, out d_h2);
            double.TryParse(h3.Text, out d_h3);
            double.TryParse(h4.Text, out d_h4);
            double.TryParse(h5.Text, out d_h5);
            double.TryParse(t1.Text, out d_t1);
            double.TryParse(t2.Text, out d_t2);
            double.TryParse(t3.Text, out d_t3);
            double.TryParse(t4.Text, out d_t4);
            double.TryParse(d.Text, out d_d);
            double.TryParse(dt.Text, out d_t);
            double.TryParse(Qsk.Text, out qsk);
            double.TryParse(Qpk.Text, out qpk);
            double.TryParse(H.Text, out h);
            double.TryParse(pp1.Text, out p1);
            double.TryParse(pp2.Text, out p2);
            double.TryParse(ff.Text, out fi);

            double result1 = d_d * Math.PI * d_h1 * qsk + (d_d - d_t1) * Math.PI * d_h2 * qsk + (d_d - d_t1 - d_t2) * Math.PI * d_h3 * qsk + (d_d - d_t1 - d_t2 - d_t3) * Math.PI * d_h4 * qsk + (d_d - d_t1 - d_t2 - d_t3 - d_t4) * Math.PI * d_h5 * qsk;

            double result2 = (Math.Pow(2, d_d) - Math.Pow(2, (d_d - d_t1))) / 4 * Math.PI * qpk + (Math.Pow(2, (d_d - d_t1)) - Math.Pow(2, (d_d - d_t1 - d_t2))) / 4 * Math.PI * qpk + (Math.Pow(2, (d_d - d_t1 - d_t2)) - Math.Pow(2, (d_d - d_t1 - d_t2 - d_t3))) / 4 * Math.PI * qpk + (Math.Pow(2, (d_d - d_t1 - d_t2 - d_t3)) - Math.Pow(2, (d_d - d_t1 - d_t2 - d_t3 - d_t4))) / 4 * Math.PI * qpk;

            double min = p1 * result1 + p2 * result2 + Math.PI * Math.Cos(fi) * (Math.Sin(fi) / Math.Cos(45 - 0.5 * fi) * h * h + Math.Sin(45 - 1.5 * fi) + Math.Sin(fi) / Math.Cos(45 - 0.5 * fi) * d_t * h);
            double result3;

            for (double i = 0; i <= 90; i = i + 0.5)
            {
                result3 = p1 * result1 + p2 * result2 + Math.PI * Math.Cos(fi) * (Math.Sin(fi) / Math.Cos(i) * h * h + Math.Sin(i - fi) + Math.Sin(fi) / Math.Cos(i) * d_t * h);
                if (result3 < min)
                    min = result3;
            }

            this.p_s.Text = result1.ToString();
            this.p_v.Text = result2.ToString();
            this.p.Text = min.ToString();
        }

        private void ButtonDetail_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            //Window1 window = new Window1();
            //window.ShowDialog();
            this.IsEnabled = true;
        }

    }
}
