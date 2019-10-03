using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CongTruNhanChia2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btntong_Click(object sender, RoutedEventArgs e)
        {
            

            float a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = a + b;
            txtdapan.Text = String.Format("0:0.0)", c);
            txtdapan.Text = c.ToString();
        }

        private void btnhieu_Click(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = a - b;
            txtdapan.Text = String.Format("0:0.0)", c);
            txtdapan.Text = c.ToString();
        }

        private void btntich_Click(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = a * b;
            txtdapan.Text = String.Format("0:0.0)", c);
            txtdapan.Text = c.ToString();
        }

        private void btnthuong_Click(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = a / b;
            if (b == 0)
            {
                MessageBox.Show("Thao tac sai");
            }
            else
            {
                c = a / b;
                txtdapan.Text = String.Format("0:0.0)", c);
                txtdapan.Text = c.ToString();
            }
        }

        private void btnthoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txta_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txthienthi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



    }
}
