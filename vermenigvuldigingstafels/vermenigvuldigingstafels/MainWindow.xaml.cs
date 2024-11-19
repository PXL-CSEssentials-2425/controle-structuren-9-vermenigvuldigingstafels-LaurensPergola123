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

namespace vermenigvuldigingstafels
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("De tafels van vermenigvuldiging:");

            const int startNumber = 1;
            const int endNumber = 12;

            for (int i = startNumber; i <= endNumber; i++) 
            {
                for (int j = startNumber; j <= endNumber; j++) 
                { 
                    result.AppendLine($"{i} * {j} = {i * j} ");
                }
                
            }
            resultTextBox.Text = result.ToString();
        }
        private void eraseButton_Click_1(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}