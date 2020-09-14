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

namespace prb.arrays01.WPF
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
        enum numberNames { een, twee, drie, vier, vijf, zes }
        Random rnd;
        int[] numbers;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rnd = new Random();
        }

        private void btnThrow_Click(object sender, RoutedEventArgs e)
        {
            numbers = new int[6];
            numbers[0] = rnd.Next(1, 7);
            numbers[1] = rnd.Next(1, 7);
            numbers[2] = rnd.Next(1, 7);
            numbers[3] = rnd.Next(1, 7);
            numbers[4] = rnd.Next(1, 7);
            numbers[5] = rnd.Next(1, 7);

            lstDice.ItemsSource = numbers;
        }

        private void lstDice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblNumberName.Content = "";
            if (lstDice.SelectedItem != null)
            {
                int chosenNumber = (int)lstDice.SelectedItem;
                lblNumberName.Content = Translate(chosenNumber);
            }
        }
        private string Translate(int number)
        {
            string translation = "";
            number--;
            switch (number)
            {
                case (int)numberNames.een:
                    translation =  numberNames.een.ToString();
                    break;
                case (int)numberNames.twee:
                    translation = numberNames.twee.ToString();
                    break;
                case (int)numberNames.drie:
                    translation = numberNames.drie.ToString();
                    break;
                case (int)numberNames.vier:
                    translation = numberNames.vier.ToString();
                    break;
                case (int)numberNames.vijf:
                    translation = numberNames.vijf.ToString();
                    break;
                default:
                    translation = numberNames.zes.ToString();
                    break;
            }
            return translation;
        }
    }
}
