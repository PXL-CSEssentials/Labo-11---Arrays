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

namespace Labo_11___Arrays
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

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            int[] getallen = { 100, 50, 20, 60, 90, 80 };
            int[] result = ReturnSmallestAndBiggest(getallen);

            StringBuilder sbOutput = new StringBuilder();
            sbOutput.AppendLine($"In totaal zijn er {getallen.Length} getallen: ");
            sbOutput.AppendLine($"Kleinste getal = {result[0]}");
            sbOutput.Append($"Grootste getal = {result[1]}");
            outputTextBox.Text = sbOutput.ToString();
        }

        private int[] ReturnSmallestAndBiggest(int[] range)
        {
            int[] result = new int[2];
            result[0] = range[0];
            result[1] = range[0];
            for (int i = 0; i < range.Length; i++)
            {
                if (range[i] < result[0])
                {
                    result[0] = range[i];
                }
                if (range[i] > result[1])
                {
                    result[1] = range[i];
                }
            }
            return result;
        }
    }
}