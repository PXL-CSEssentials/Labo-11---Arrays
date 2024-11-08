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
            int smallest = int.MaxValue;
            int biggest = int.MinValue;

            //int[] getallen = new int[6] { 100, 50, 20, 60, 90, 80 };
            int[] getallen = { 100, 50, 20, 60, 90, 80 };
            StringBuilder sbOutput = new StringBuilder();
            sbOutput.Append($"In totaal zijn er {getallen.Length} getallen: ");
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] > biggest)
                {
                    biggest = getallen[i];
                }
                if (getallen[i] < smallest)
                {
                    smallest = getallen[i];
                }
            }
            sbOutput.AppendLine();
            sbOutput.AppendLine($"Kleinste getal = {smallest}");
            sbOutput.AppendLine($"Grootste getal = {biggest}");
            outputTextBox.Text = sbOutput.ToString();
        }
    }
}