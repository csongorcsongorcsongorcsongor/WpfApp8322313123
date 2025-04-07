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
            wi.Text = wi.Tag.ToString();
            hi.Text = hi.Tag.ToString();



            wi.GotFocus += f;
            hi.GotFocus += f;
            wi.LostFocus += uf;
            hi.LostFocus += uf;
            wi.KeyDown += e;
            hi.KeyDown += e;
            

        }
        void e(object s, KeyEventArgs e)
        {
           if(e.Key == Key.Enter)
           {
                int temp;
                int temp2;
                if (int.TryParse(wi.Text, out temp) && int.TryParse(hi.Text, out temp2))
                {
                    r.Content = temp / (Math.Pow(((float)temp2/100),2));
                }
                else
                {
                    MessageBox.Show("szar");
                }
           }
        }
        void f(object s, EventArgs e)
        {
            TextBox tbox = s as TextBox;

            if(tbox.Text == tbox.Tag.ToString())
            {
                tbox.Text = "";
            }

            

        }
        void uf(object s, EventArgs e)
        {
            TextBox tbox = s as TextBox;

            if (tbox.Text == "")
            {
                tbox.Text = tbox.Tag.ToString();
            }

        }
        void k(object s, EventArgs e)
        {
            
        }
    }
}
