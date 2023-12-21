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
            Complex sum = new();
            sum= add_lhs+add_rhs;
            result_LH.Text = sum.Re.ToString();
            result_RH.Text = sum.Im.ToString();

        }

        private void Button_Click_sub(object sender, RoutedEventArgs e)
        {
            Complex slhs = new Complex(double.Parse(lhs_real.Text), double.Parse(lhs_imag.Text));
            Complex srhs = new Complex(double.Parse(rhs_real.Text), double.Parse(rhs_imag.Text));
            Complex diff = new();
            diff=slhs-srhs;
            result_LH.Text = diff.Re.ToString();
            result_RH.Text = diff.Im.ToString();
        }

        private void Button_Click_multi(object sender, RoutedEventArgs e)
        {
            Complex lhs = new Complex(double.Parse(lhs_real.Text), double.Parse(lhs_imag.Text));
            Complex rhs = new Complex(double.Parse(rhs_real.Text), double.Parse(rhs_imag.Text));
            Complex multi = new();
            multi=lhs*rhs;
            result_LH.Text = multi.B.ToString();
            result_RH.Text = multi.W.ToString();

        }

         private void Button_Click_div(object sender, RoutedEventArgs e)
         {
            Complex lhs = new Complex(double.Parse(lhs_real.Text), double.Parse(lhs_imag.Text));
            Complex rhs = new Complex(double.Parse(rhs_real.Text), double.Parse(rhs_imag.Text));
            Complex div = new();
            div=lhs/rhs;
            result_LH.Text = div.B.ToString();
            result_RH.Text = div.W.ToString();
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

    }



   
}