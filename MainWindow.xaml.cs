using System.Numerics;
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

namespace Complex_calc
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

        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            Complex add_lhs = new Complex(double.Parse(lhs_real.Text), double.Parse(lhs_imag.Text));
            Complex add_rhs = new Complex(double.Parse(rhs_real.Text), double.Parse(rhs_imag.Text));
            add_rhs.Add(add_lhs);
            result_LH.Text = add_rhs.RE.ToString();
            result_RH.Text = add_rhs.IM.ToString();

        }

        private void Button_Click_sub(object sender, RoutedEventArgs e)
        {
            Complex slhs = new Complex();
            Complex srhs = new Complex();
            slhs.RE = double.Parse(lhs_real.Text);
            slhs.IM = double.Parse(lhs_imag.Text);
            srhs.RE = double.Parse(rhs_real.Text);
            srhs.IM = double.Parse(rhs_imag.Text);
            slhs.Sub(srhs);
            result_LH.Text = slhs.RE.ToString();
            result_RH.Text = slhs.IM.ToString();
        }

        private void Button_Click_multi(object sender, RoutedEventArgs e)
        {
            Complex lhs = new Complex(double.Parse(lhs_real.Text), double.Parse(lhs_imag.Text));
            Complex rhs = new Complex(double.Parse(rhs_real.Text), double.Parse(rhs_imag.Text));
            Complex multi = new();
            multi.Multi(lhs, rhs);
            result_LH.Text = multi.RE.ToString();
            result_RH.Text = multi.IM.ToString();

        }

         private void Button_Click_div(object sender, RoutedEventArgs e)
         {
            Complex lhs = new Complex(double.Parse(lhs_real.Text), double.Parse(lhs_imag.Text));
            Complex rhs = new Complex(double.Parse(rhs_real.Text), double.Parse(rhs_imag.Text));
            Complex div = new();
            div.Div(lhs, rhs);
            result_LH.Text = div.RE.ToString();
            result_RH.Text = div.IM.ToString();
        }

        private void Button_Click_AC(object sender, RoutedEventArgs e)
        {
            result_RH.Text = "0";
            result_LH.Text = "0";
            lhs_imag.Text = "0";
            lhs_real.Text = "0";
            rhs_imag.Text = "0";
            rhs_real.Text = "0";
        }

        private void lhs_imag_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }



   
}