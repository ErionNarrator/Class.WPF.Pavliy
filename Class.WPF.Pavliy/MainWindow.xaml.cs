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

namespace Class.WPF.Pavliy
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double var1 = double.Parse(VAR1.Text);
                double var2 = double.Parse(VAR2.Text);
                double S = var1 + var2;
                Resalt.Text = S.ToString();

            }
            catch (Exception ex)
            {

                Resalt.Text = ex.Message;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double var1 = double.Parse(VAR1.Text);
                double var2 = double.Parse(VAR2.Text);
                double d = var1 - var2;
                Resalt.Text = d.ToString();
            }
            catch (Exception ex)
            {
                Resalt.Text = ex.Message;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double var1 = double.Parse(VAR1.Text);
                double var2 = double.Parse(VAR1.Text);
                double m = var1 * var2;
                Resalt.Text = m.ToString();
            }

            catch(Exception ex)
            {
                Resalt.Text = ex.Message;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double var1 = double.Parse(VAR1.Text);
                double var2 = double.Parse(VAR1.Text);
                if (var2 == 0) MessageBox.Show("Деление на 0 круто");
                else
                {
                    double S = var1 / var2;
                    Resalt.Text = S.ToString();
                }
            }
            catch (Exception ex)
            {
                Resalt.Text=ex.Message;
            }
        }
    }
}