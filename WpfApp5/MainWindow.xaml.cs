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

namespace WpfApp5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string Number1=null, Number2=null,flag=null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if(flag==null)
            {
                Number1 = Number1 + "7";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "7";
                label1.Content = Number2;
            }
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "8";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "8";
                label1.Content = Number2;
            }
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "9";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "9";
                label1.Content = Number2;
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "6";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "6";
                label1.Content = Number2;
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "5";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "5";
                label1.Content = Number2;
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "4";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "4";
                label1.Content = Number2;
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "3";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "3";
                label1.Content = Number2;
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "2";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "2";
                label1.Content = Number2;
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "1";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "1";
                label1.Content = Number2;
            }
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + "0";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "0";
                label1.Content = Number2;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 = Number1 + ".";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + ".";
                label1.Content = Number2;
            }
        }
        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            flag = "+";
        }
        private void Button_sub_Click(object sender, RoutedEventArgs e)
        {
            flag = "-";
        }
        private void Button_mul_Click(object sender, RoutedEventArgs e)
        {
            flag = "*";
        }
        private void Button_div_Click(object sender, RoutedEventArgs e)
        {
            flag = "/";
        }
        private void Button_equ_Click(object sender, RoutedEventArgs e)
        {
            switch(flag)
            {
                case "+":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2));
                    break;
                case "-":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2));
                    break;
                case "*":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2));
                    break;
                case "/":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2));
                    break;
            }
            Number1 = null;
            Number2 = null;
            flag = null;

        }
    }
}
