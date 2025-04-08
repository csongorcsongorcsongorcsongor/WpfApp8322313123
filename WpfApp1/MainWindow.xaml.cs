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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            start();
        }
        void start()
        { 
            wi.GotFocus += f;
            hi.GotFocus += f;
            ni.GotFocus += f;
            ai.GotFocus += f;
            wi.LostFocus += uf;
            hi.LostFocus += uf;
            ni.LostFocus += uf;
            ai.LostFocus += uf;
            wi.KeyDown += e;
            hi.KeyDown += e;
            ni.KeyDown += e;
            ai.KeyDown += e;
            

        }
        void e(object s, KeyEventArgs e)
        {
           //if(e.Key == Key.Enter)
           //{
           //     int temp;
           //     int temp2;
           //     if (int.TryParse(wi.Text, out temp) && int.TryParse(hi.Text, out temp2))
           //     {
           //         r.Content = temp / (Math.Pow(((float)temp2/100),2));
           //     }
           //     else
           //     {
           //         MessageBox.Show("szar");
           //     }
           //}

            if(e.Key == Key.Enter)
            {
                int w;
                int h;
                if(int.TryParse(wi.Text.Trim(),out w) && int.TryParse(hi.Text.Trim(),out h))
                {
                    double BMI = w / Math.Pow(((double)h / 100), 2);
                    ev.Children.Add(new Label() { Content = $"Név: {ai.Text}, Életkor:  {ai.Text}, BMI: {BMI.ToString("0.00")} vagyis {ow(BMI)}" });
                }
            }
        }
        string ow(double BMI)
        {
            if (BMI < 18.5)
            {
                return "sovány";
            }
            if (BMI < 25)
            {
                return "normál";
            }
            if (BMI < 30)
            {
                return "dagadek";
            }
            if (BMI < 35)
            {
                return "kurva dagadek";
            }
            if (BMI < 40)
            {
                return "kys fatass";
            }
            return "dagi";
        }
        void f(object s, EventArgs e)
        {
            //TextBox tbox = s as TextBox;

            //if(tbox.Text == tbox.Tag.ToString())
            //{
            //    tbox.Text = "";
            //}

            TextBox sender = s as TextBox;
            if(sender.Text == sender.Tag.ToString())
            {
                sender.Clear();
            }

            

        }
        void uf(object s, EventArgs e)
        {
            //TextBox tbox = s as TextBox;

            //if (tbox.Text == "")
            //{
            //    tbox.Text = tbox.Tag.ToString();
            //}

            TextBox sender = s as TextBox;
            if(sender.Text == "")
            {
                sender.Text = sender.Tag.ToString();
            }

        }
    }
}
